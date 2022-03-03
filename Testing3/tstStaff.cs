using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
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
    }
}
