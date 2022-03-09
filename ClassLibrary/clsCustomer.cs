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


    }
}