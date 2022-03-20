using System;

namespace ClassLibrary
{
    public class clsStaff

    {
        private String mStaffFirstName;
        private String mStaffLastName;
        private Int32 mStaffID;
        private bool mStaffEmployed;
        private DateTime mStaffEndDate;
        private double mStaffSalary;
        public bool StaffEmployed
        {
            get
            {
                return mStaffEmployed;
            }
            set
            {
                mStaffEmployed = value;
            }
        }
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public DateTime StaffEndDate
        {
            get
            {
                return mStaffEndDate;
            }
            set
            {
                mStaffEndDate = value;
            }
        }
        public string StaffLastName
        {
            get
            {
                return mStaffLastName;
            }
            set
            {
                mStaffLastName = value;
            }
        }
        public string StaffFirstName
        {
            get
            {
                return mStaffFirstName;
            }
            set
            {
                mStaffFirstName = value;
            }
        }
        public double StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffEmployed"]);
                mStaffEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffEndDate"]);
                mStaffSalary = Convert.ToDouble(DB.DataTable.Rows[0]["StaffSalary"]);
                return true;
            }
            else {
                return false;
            }
           
           
        }
       
    }
}