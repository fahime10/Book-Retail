using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {

            }
        }

        //public property for ThisBook
        public clsStaff ThisStaff
        {
            get
            {
                return ThisStaff;
            }
            set
            {
                ThisStaff = value;
            }
        }


        public void PopulateArray()
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            //clear the private array list
            StaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank book
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["BookTitle"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["BookPrice"]);
                AStaff.StaffEndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BookQuantity"]);
                AStaff.StaffSalary = Convert.ToDouble(DB.DataTable.Rows[Index]["BookAvailability"]);
                AStaff.StaffEmployed = Convert.ToBoolean(DB.DataTable.Rows[Index]["DateReceived"]);
                //add the record to the private data member
                StaffList.Add(AStaff);
                //point at the next record
                Index++;
            }


        }
    }
}