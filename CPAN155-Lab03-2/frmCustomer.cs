using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CakeClasses;
using DatabaseClasses;

namespace CPAN155_Lab03_2
{
    public partial class frmCustomer : Form
    {
        public static Customer customer;
        CakeCustomers cakeCustomers;

        public frmCustomer()
        {
            InitializeComponent();
            cakeCustomers = new CakeCustomers();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            frmOrder child = new frmOrder();
            bool isChecked = true;
            if (!System.Text.RegularExpressions.Regex.Match(txtLastName.Text, "^[a-zA-Z]+$").Success)
            {
                isChecked = false;
                inputErrorProvider.SetError(txtLastName, "Please type a string.");
            }

            if (isChecked)
            {
                inputErrorProvider.Clear();

                customer = cakeCustomers.GetCustomer(txtLastName.Text);

                // Filling out information
                txtFirstName.Text = customer.FirstName;
                txtAddress.Text = customer.address.StreetAddress;
                txtCity.Text = customer.address.City;
                txtPostalCode.Text = customer.address.PostalCode;
                txtProvince.Text = customer.address.Province;

                // Mailings check
                if (customer.address.Mail1 != -1)
                {
                    lstMail.SetItemChecked(customer.address.Mail1, true);
                }
                if (customer.address.Mail3 != -1)
                {
                    lstMail.SetItemChecked(customer.address.Mail2, true);
                }
                if (customer.address.Mail3 != -1)
                {
                    lstMail.SetItemChecked(customer.address.Mail3, true);
                }

                // Mailings loop
                if (lstMail.SelectedItems.Count != -1)
                {
                    for (int i = 0; i < lstMail.CheckedItems.Count; i++)
                    {
                        customer.address.AddMail(lstMail.CheckedItems[i].ToString());
                    }
                }
                child.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear your form?",
                                                  "Clear",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtPostalCode.Text = "";
                txtProvince.Text = "";
                foreach (int i in lstMail.CheckedIndices)
                {
                    lstMail.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            cakeCustomers.Close();
        }
    }
}
