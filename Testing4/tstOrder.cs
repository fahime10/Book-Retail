using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
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
            if (AnOrder.DateAdded != Convert.ToDateTime("10/11/2021"))
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
            AnOrder.DateAdded = TestData;
            Assert.AreEqual(AnOrder.DateAdded, TestData);
            
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
        

    }
}
