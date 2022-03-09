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
            mCustomerID = 1;
            mCustomerAccCreated = Convert.ToDateTime("05/10/2020");
            mCustomerFirstName = "Joe";
            mCustomerLastName = "Bloggs";
            mCustomerAddress = "33 Tor Church Road, Torquay,TQ2 5UP";
            mExistingAcc = true;
            return true;
        }


    }
}