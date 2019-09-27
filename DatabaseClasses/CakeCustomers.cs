using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Threading.Tasks;
using CakeClasses;

namespace DatabaseClasses
{
    public class CakeCustomers
    {
        private OracleConnection oracleConnection;
        private OracleCommand oracleCommand;
        private OracleDataReader oracleDataReader;
        private const string HOST = "calvin.humber.ca";
        private const string SID = "grok";
        internal const string PASSWORD = "oracle";
        private const string USER_ID = "n01232785";

        private static readonly string strCONNECTIONSTRING = string.Format("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +
                                                            "(HOST={0})(PORT=1521))(CONNECT_DATA=(SID={1}))); " +
                                                            "PASSWORD={2}; USER ID={3}", HOST, SID, PASSWORD, USER_ID);

        public CakeCustomers()
        {
            try
            {
                oracleConnection = new OracleConnection(strCONNECTIONSTRING);
                oracleCommand = new OracleCommand();
                oracleCommand.Connection = oracleConnection;
                oracleConnection.Open();
                CreateTable(oracleCommand);
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        public void CreateTable(OracleCommand oracleCommand)
        {
            oracleCommand.CommandText = "create table CAKE_CUSTOMERS (FIRST varchar2(30), LAST varchar2(30), ADDRESS varchar2(30), CITY varchar2(30), POSTAL varchar2(30), PROVINCE varchar2(30), MAIL_1 number(1), MAIL_2 number(1), MAIL_3 number(1))";
            oracleCommand.ExecuteNonQuery();
            oracleCommand.CommandText = "insert into CAKE_CUSTOMERS values('Francis', 'Taco', '1184 Barry Lane', 'Mississauga', 'L5E2E1', 'ON', '0', '-1', '-1')";
            oracleCommand.ExecuteNonQuery();
            oracleCommand.CommandText = "insert into CAKE_CUSTOMERS values('John', 'Lemon', '3214 Gardner Ave', 'Glendale', '23K6lS', 'ON', '-1', '1', '-1')";
            oracleCommand.ExecuteNonQuery();
            oracleCommand.CommandText = "insert into CAKE_CUSTOMERS values('Hank', 'Peanut', '2352 23rd Street', 'Brampton', 'GM3F20', 'ON', '-1', '-1', '2')";
            oracleCommand.ExecuteNonQuery();
            oracleCommand.CommandText = "insert into CAKE_CUSTOMERS values('Sonny', 'Leek', '5203 Danum Rd', 'Etobicoke', 'TRQ329', 'ON', '-1', '-1', '-1')";
            oracleCommand.ExecuteNonQuery();
            oracleCommand.CommandText = "insert into CAKE_CUSTOMERS values('Marcus', 'Alfredo', '4973 Snape Blvd', 'Hamilton', '62PI2U', 'ON', '0', '1', '2')";
            oracleCommand.ExecuteNonQuery();
        }

        public Customer GetCustomer(string lastName)
        {
            string strQUERY = "select * from CAKE_CUSTOMERS where LAST = '" + lastName + "'";
            Customer customer = new Customer();
            try
            {
                oracleCommand.CommandText = strQUERY;
                oracleDataReader = oracleCommand.ExecuteReader();

                if (oracleDataReader.Read())
                {
                    customer.FirstName = oracleDataReader["FIRST"].ToString();
                    customer.LastName = oracleDataReader["LAST"].ToString();
                    customer.address.StreetAddress = Convert.ToString(oracleDataReader["ADDRESS"]);
                    customer.address.City = Convert.ToString(oracleDataReader["CITY"]);
                    customer.address.PostalCode = Convert.ToString(oracleDataReader["POSTAL"]);
                    customer.address.Province = Convert.ToString(oracleDataReader["PROVINCE"]);
                    customer.address.Mail1 = Convert.ToInt32(oracleDataReader["MAIL_1"]);
                    customer.address.Mail2 = Convert.ToInt32(oracleDataReader["MAIL_2"]);
                    customer.address.Mail3 = Convert.ToInt32(oracleDataReader["MAIL_3"]);
                }
                else
                {
                    Exception myException = new Exception("Sorry, that name doesn't exist on the database");
                    throw myException;
                }
                oracleDataReader.Close();
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return customer;
        }

        public void DropTable(OracleCommand command)
        {
            try
            {
                command.CommandText = "drop table CAKE_CUSTOMERS";
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Close()
        {
            try
            {
                if (oracleConnection.State != System.Data.ConnectionState.Closed)
                {
                    DropTable(oracleCommand);
                    oracleConnection.Close();
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
    }
}
