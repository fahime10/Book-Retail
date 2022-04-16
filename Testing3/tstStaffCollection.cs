using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllAddress = new clsStaffCollection();
            Assert.IsNotNull(AllAddress);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestStaff = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 5;
            TestItem.StaffFirstName = "Adam";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffEndDate = DateTime.Now.Date;
            TestItem.StaffSalary = 20000;
            TestItem.StaffEmployed = true;
            TestStaff.Add(TestItem);
            AllStaff.StaffList = TestStaff;
            Assert.AreEqual(AllStaff.StaffList, TestStaff);

        }
        
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffID = 5;
            TestStaff.StaffFirstName = "Adam";
            TestStaff.StaffLastName = "Smith";
            TestStaff.StaffEndDate = DateTime.Now.Date;
            TestStaff.StaffSalary = 20000;
            TestStaff.StaffEmployed = true;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

       
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestStaff = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 5;
            TestItem.StaffFirstName = "Adam";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffEndDate = DateTime.Now.Date;
            TestItem.StaffSalary = 20000;
            TestItem.StaffEmployed = true;
            TestStaff.Add(TestItem);
            AllStaff.StaffList = TestStaff;
            Assert.AreEqual(AllStaff.Count, TestStaff.Count);
        }
    }
}



