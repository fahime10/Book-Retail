using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
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
        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer TheCustomer = new clsCustomer();
                TheCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                TheCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                TheCustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                TheCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                TheCustomer.CustomerAccCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerAccCreated"]);
                TheCustomer.ExistingAcc = Convert.ToBoolean(DB.DataTable.Rows[Index]["ExistingAcc"]);
                mCustomerList.Add(TheCustomer);
                Index++;
            }
        }
    }
}