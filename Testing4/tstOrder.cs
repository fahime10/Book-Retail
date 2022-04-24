using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        string UnitQuantity = "1";
        string TotalPrice = "12.3";
        string ShipAddress = "April Cottage, Lastingham, YO62 6TJ";
        string OrderDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void OrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.totalPrice != 12.3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("10/11/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUnitQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.unitQuantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void IsStaffFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.isStaff != false)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ShipAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.ShipAddress != "April Cottage, Lastingham, YO62 6TJ")
            {
                OK = false;
            }
            Assert.IsTrue(Found);

        }



        [TestMethod]
        public void isStaffOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.isStaff = TestData;
            Assert.AreEqual(AnOrder.isStaff, TestData);

        }

        [TestMethod]
        public void orderPlacedDateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
            
        }

        [TestMethod]
        public void unitQuantityOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.unitQuantity = TestData;
            Assert.AreEqual(AnOrder.unitQuantity, TestData);
        }

        [TestMethod]
        public void ShipAddressOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "54, highfield Street, Leicester, LE2 1AD";
            AnOrder.ShipAddress = TestData;
            Assert.AreEqual(AnOrder.ShipAddress, TestData);
        }

        [TestMethod]
        public void totalPriceOK()
        {
            clsOrder AnOrder = new clsOrder();
            double TestData = 12.23;
            AnOrder.totalPrice = TestData;
            Assert.AreEqual(AnOrder.totalPrice, TestData);

        }

        public void orderIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShipAddressinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShipAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "a";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShipAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "aa";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShipAddressMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShipAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShipAddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShipAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "";
            ShipAddress = ShipAddress.PadRight(101, 'a');
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShipAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShipAddress = "";
            ShipAddress = ShipAddress.PadRight(500, 'a');
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid( UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid( UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDate = "This is not a date! ";
            Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}
