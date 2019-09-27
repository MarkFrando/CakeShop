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

namespace CPAN155_Lab03_2
{
    public partial class frmOrder : Form
    {
        Order order;
        Random rand = new Random();

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmCake_Load(object sender, EventArgs e)
        {
            order = new Order();
            radCustom.Checked = true;
            radChocolate.Checked = true;
            radAnniversary.Checked = true;
            radTier1.Checked = true;
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            grpCustomCake.Enabled = true;
            lstTraditional.Enabled = false;
        }

        private void radTraditional_CheckedChanged(object sender, EventArgs e)
        {
            grpCustomCake.Enabled = false;
            lstTraditional.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validation checks on all Radio Buttons
            bool isChecked = true;
            if (!radCustom.Checked && !radTraditional.Checked)
            {
                isChecked = false;
            }
            if (!radChocolate.Checked && !radVanilla.Checked && !radBanana.Checked && radCustom.Checked)
            {
                isChecked = false;
            }
            if (!radAnniversary.Checked && !radGraduation.Checked && !radWedding.Checked && radCustom.Checked)
            {
                isChecked = false;
            }
            if (!radTier1.Checked && !radTier2.Checked && !radTier3.Checked && radCustom.Checked)
            {
                isChecked = false;
            }

            // Adding to List if Parameters are correct else show Error
            if (isChecked)
            {
                if (radCustom.Checked)
                {
                    order.AddCakes(radAnniversary.Checked, radGraduation.Checked, radWedding.Checked,
                                   radChocolate.Checked, radVanilla.Checked, radBanana.Checked,
                                   radTier1.Checked, radTier2.Checked, radTier3.Checked);

                }
                if (radTraditional.Checked)
                {
                    for (int i = 0; i < lstTraditional.SelectedItems.Count; i++)
                    {
                        order.AddCakes(lstTraditional.SelectedIndices[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out your order.", "Error");
            }
            this.DialogResult = DialogResult.None;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show(order.ViewOrder(), "You Have Ordered");
            this.DialogResult = DialogResult.None;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            order.lstCakes.Clear();
            order.Quantity = 0;
            order.TotalPrice = 0;
            MessageBox.Show("Your cart has been cleared of any purchases.", "Cart Cleared");
            this.DialogResult = DialogResult.None;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Check to aee if any Orders have not been placed
            if(order.lstCakes.Count == 0)
            {
                MessageBox.Show("Please order a cake before you checkout!", "What are you even here for");
            }
            else
            {
                // Confirmation Box
                DialogResult result = MessageBox.Show(frmCustomer.customer.ToString() + frmCustomer.customer.address.ToString() + order.ToString(),
                                                      "Confirm Order",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);

                // Confirmation Code
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(frmCustomer.customer.ToString() + 
                                    "\nYour order has been placed. Your confirmation code is: " +
                                    rand.Next(10000, 999999).ToString(), "Thank You!");
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Order Cancelled.", "Confirm Order");
                }
            }
            this.DialogResult = DialogResult.None;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radCustom.Checked = false;
            radTraditional.Checked = false;
            lstTraditional.SelectedIndex = -1;
            radChocolate.Checked = false;
            radVanilla.Checked = false;
            radBanana.Checked = false;
            radAnniversary.Checked = false;
            radGraduation.Checked = false;
            radWedding.Checked = false;
            radTier1.Checked = false;
            radTier2.Checked = false;
            radTier3.Checked = false;
            this.DialogResult = DialogResult.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
