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

        public string Valid(string staffFirstName, string staffLastName, string staffEndDate, string staffSalary, string staffEmployed)
        {
            String Error = "";
            DateTime TempDate;
            double Salary;
            bool Employed;
            if (staffFirstName.Length == 0)
            {
                Error = Error + "The Staff's First Name may not be null : ";
            }
            if (staffFirstName.Length > 20)
            {
                Error = Error + "The Staff's First Name must be less than 20 characters : ";
            }
            if (staffLastName.Length == 0)
            {
                Error = Error + "The Staff's Last Name may not be null : ";
            }
            if (staffLastName.Length > 20)
            {
                Error = Error + "The Staff's Last Name must be less than 20 characters : ";
            }

            try
            {
                Employed = Convert.ToBoolean(staffEmployed);
                TempDate = Convert.ToDateTime(staffEndDate);
                if (TempDate < DateTime.Now.Date)
                {
                    
                    if (Employed)
                    {
                        Error = Error + " Employment End Date cannot be in the past whilst the Employee be Employed  : ";
                    }
                }

                if (TempDate > DateTime.Now.Date)
                {
                    if (!Employed)
                    {
                        Error = Error + "Employment End Date cannot be in the future whilst the Employee is not Employed: ";

                    }
                }
                    
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            try
            {
                Salary = Convert.ToDouble(staffSalary);

                if (Salary < 0.00)
                {
                    Error = Error + "The Staff Salary cannot be lower than £0.00 : ";
                }

                if (Salary > 100000.00)
                {
                    Error = Error + "The Staff Salary cannot be more than £1,000,000.00 : ";
                }
            }
            catch
            {
                Error = Error + "The price given was not a valid price : ";
            }
            return Error;
        }
    }
}