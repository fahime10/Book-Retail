using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList 
        {
            get 
            { 
              return mCustomerList  ;
            }
            set 
            {
                mCustomerList = value;   ;
            } 
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                
            }
        }
        public clsCustomer ThisCustomer 
        { 
            get 
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
           
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
             
            
        }

        private void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                 clsCustomer TheCustomer = new clsCustomer();
                 TheCustomer.ExistingAcc = Convert.ToBoolean(DB.DataTable.Rows[Index]["ExistingAcc"]);
                 TheCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                 TheCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                 TheCustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                 TheCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                 TheCustomer.CustomerAccCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerAccCreated"]);
                 
                 mCustomerList.Add(TheCustomer);
                 Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFirstName",mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerAccCreated", mThisCustomer.CustomerAccCreated);
            DB.AddParameter("@ExistingAcc", mThisCustomer.ExistingAcc);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerAccCreated", mThisCustomer.CustomerAccCreated);
            DB.AddParameter("@ExistingAcc", mThisCustomer.ExistingAcc);

            DB.Execute("sproc_tblCustomer_update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFirstName", FirstName);
            DB.Execute("sproc_tblCustomer_FilteredByFirstName");
            PopulateArray(DB);
        }

       
    }
}