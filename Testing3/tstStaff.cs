using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        string StaffFirstName = "Adam";
        string StaffLastName = "Smith";
        string StaffSalary = "20000";
        string StaffEndDate = DateTime.Now.Date.ToString();
        string StaffEmployed = "true";
        [TestMethod]
        public void InstanceOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //tests to see if it is not null
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void StaffEmployedOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //creates a boolean test data 
            Boolean TrueData = true;
            //assigns the data in the sql table equal to the variable above
            AStaff.StaffEmployed = TrueData;
            //checks to see if they are equal
            Assert.AreEqual(AStaff.StaffEmployed, TrueData);
        }
        [TestMethod]
        public void StaffSalaryOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //creates a double test data 
            double TrueData = 20000;
            //assigns the data in the sql table equal to the variable above
            AStaff.StaffSalary = TrueData;
            //checks to see if they are equal
            Assert.AreEqual(AStaff.StaffSalary, TrueData);
        }
        [TestMethod]
        public void StaffFirstNameOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //creates a string test data 
            String TrueData = "Adam";
            //assigns the data in the sql table equal to the variable above
            AStaff.StaffFirstName = TrueData;
            //checks to see if they are equal
            Assert.AreEqual(AStaff.StaffFirstName, TrueData);
        }
        [TestMethod]
        public void StaffLastNameOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //creates a string test data 
            String TrueData = "Smith";
            //assigns the data in the sql table equal to the variable above
            AStaff.StaffLastName = TrueData;
            //checks to see if they are equal
            Assert.AreEqual(AStaff.StaffLastName, TrueData);
        }
        [TestMethod]
        public void StaffEndDateOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //creates a DateTime test data 
            DateTime TrueData = DateTime.Now.Date;
            //assigns the data in the sql table equal to the variable above
            AStaff.StaffEndDate = TrueData;
            //checks to see if they are equal
            Assert.AreEqual(AStaff.StaffEndDate, TrueData);
        }
        [TestMethod]
        public void StaffIDOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //creates a Integer test data 
            Int32 TrueData = 5;
            //assigns the data in the sql table equal to the variable above
            AStaff.StaffID = TrueData;
            //checks to see if they are equal
            Assert.AreEqual(AStaff.StaffID, TrueData);
        }
        [TestMethod]
        public void FindMethodOK()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //creates a Integer test data 
            Boolean Found = false;
            Int32 ID = 5;

            //assigns the data in the sql table equal to the variable above
            Found = AStaff.Find(ID);
            //checks to see if they are equal
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffFirstNameFound()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 5;

            
            Found = AStaff.Find(ID);
            if (AStaff.StaffFirstName != "Adam") 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffLastNameFound()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 5;


            Found = AStaff.Find(ID);
            if (AStaff.StaffLastName != "Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffEmployedFound()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 5;


            Found = AStaff.Find(ID);
            if (AStaff.StaffEmployed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ID =5;


            Found = AStaff.Find(ID);
            if (AStaff.StaffID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffEndDateFound()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 5;
            Found = AStaff.Find(ID);
            if (AStaff.StaffEndDate != Convert.ToDateTime("13/06/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffSalaryFound()
        {   //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 5;
            Found = AStaff.Find(ID );
            if (AStaff.StaffSalary != 20000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate,StaffSalary,StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "";
            Error = AStaff.Valid(firstname, StaffLastName,StaffEndDate,StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffFirstNameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "A";
            Error = AStaff.Valid(firstname, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "AA";
            Error = AStaff.Valid(firstname, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error,"");
        }
        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "";
            firstname = firstname.PadRight(19,'A');
            Error = AStaff.Valid(firstname, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error,"");
        }
        [TestMethod]
        public void StaffFirstNameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "";
            firstname = firstname.PadRight(20, 'A');
            Error = AStaff.Valid(firstname, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "";
            firstname = firstname.PadRight(21, 'A');
            Error = AStaff.Valid(firstname, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffFirstNameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "";
            firstname = firstname.PadRight(10, 'A');
            Error = AStaff.Valid(firstname, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string firstname = "AA";
            firstname = firstname.PadRight(100, 'A');
            Error = AStaff.Valid(firstname, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "";
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "A";
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "AA";
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "";
            lastname = lastname.PadRight(19, 'A');
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "";
            lastname = lastname.PadRight(20, 'A');
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "";
            lastname = lastname.PadRight(21, 'A');
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "";
            lastname = lastname.PadRight(10, 'A');
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string lastname = "AA";
            lastname = lastname.PadRight(100, 'A');
            Error = AStaff.Valid(StaffFirstName, lastname, StaffEndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = -0.01;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreNotEqual(Error,"");
        }
        [TestMethod]
        public void StaffSalaryMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = 0.00;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = 0.01;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = 99999;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = 100000.00;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = 100001.00;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = 50000;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = -1000000;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            double Salary = 1000000;
            string Salaries = Salary.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salaries, StaffEmployed);

        }
        [TestMethod]
        public void StaffSalaryInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Salary = "Not A Date";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, Salary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEndDateMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestingData;
            TestingData = DateTime.Now.Date;
            TestingData = TestingData.AddDays(-1);
            string EndDate = TestingData.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, EndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEndDateMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestingData;
            TestingData = DateTime.Now.Date;
            string EndDate = TestingData.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, EndDate, StaffSalary, StaffEmployed);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEndDateMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestingData;
            TestingData = DateTime.Now.Date;
            TestingData = TestingData.AddDays(1);
            string EndDate = TestingData.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, EndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEndDateExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestingData;
            TestingData = DateTime.Now.Date;
            TestingData = TestingData.AddYears(500);
            string EndDate = TestingData.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, EndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error,"");
        }
        [TestMethod]
        public void StaffEndDateInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string EndDate = "Not A Date";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, EndDate, StaffSalary, StaffEmployed);
            Assert.AreNotEqual(Error, "");
        }
        
    }
}
