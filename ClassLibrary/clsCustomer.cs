using System;

namespace ClassLibrary
{
   
    public class clsCustomer
    { 
        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private string mCustomerFirstName;
        public string CustomerFirstName
        {
            get
            {
                return mCustomerFirstName;
            }
            set
            {
                mCustomerFirstName = value;
            }
        }

        private string mCustomerLastName;
        public string CustomerLastName 
        {
            get 
            {
                return mCustomerLastName;
            }
            set 
            {
                mCustomerLastName = value;
            } 
        }
        private string mCustomerAddress;
        public string CustomerAddress 
        { 
            get 
            {
                return mCustomerAddress;
            }
            set 
            {
                mCustomerAddress = value;
            } 
        }
        private DateTime mCustomerAccCreated;
        public DateTime CustomerAccCreated
        {
            get
            {
                return mCustomerAccCreated;
            }
            set
            {
                mCustomerAccCreated = value;
            }
        }
        private bool mExistingAcc;
        public bool ExistingAcc 
        {
            get
            {
                return mExistingAcc;
            }
            set 
            {
                mExistingAcc = value;
            } 
        }

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]); 
                mCustomerAccCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerAccCreated"]);
                mExistingAcc = Convert.ToBoolean(DB.DataTable.Rows[0]["ExistingAcc"]);
                return true;
            }
            else 
            {
                return false;
            }
        }

        public string Valid(string customerFirstName, string customerLastName, string customerAddress, string customerAccountCreated)
        {
            String Error = "";
            DateTime DateTemp;

            if (customerFirstName.Length == 0)
            {

                Error = Error + "The first name cannot be blank : ";

            }

            if(customerFirstName.Length > 25)
            {
                Error = Error + "The first name must be less than 25 characters : ";
            }

            if (customerLastName.Length == 0)
            {

                Error = Error + "The last name cannot be blank : ";

            }

            if (customerLastName.Length > 25)
            {
                Error = Error + "The last name must be less than 25 characters : ";
            }

            if (customerAddress.Length == 0)
            {

                Error = Error + "The Customers address cannot be blank : ";

            }

            if (customerAddress.Length > 50)
            {
                Error = Error + "The Customers address must be less than 50 characters : ";
            }
            try
            {

            
                DateTemp = Convert.ToDateTime(customerAccountCreated);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch 
            {
                Error = Error + "The date is not valid : ";
            }
            return Error;
        }
    }
}