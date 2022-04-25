using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 1;
            TestItem.isStaff = true;
            TestItem.unitQuantity = 1;
            TestItem.totalPrice = 12.3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShipAddress = "April Cottage, Lastingham, YO62 6TJ";

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.OrderList, TestList);



        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            TestOrder.OrderID = 1;
            TestOrder.isStaff = true;
            TestOrder.unitQuantity = 1;
            TestOrder.totalPrice = 12.3;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ShipAddress = "April Cottage, Lastingham, YO62 6TJ";

            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 1;
            TestItem.isStaff = true;
            TestItem.unitQuantity = 1;
            TestItem.totalPrice = 12.3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShipAddress = "April Cottage, Lastingham, YO62 6TJ";

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.isStaff = true;
            TestItem.unitQuantity = 1;
            TestItem.totalPrice = 12.3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShipAddress = "April Cottage, Lastingham, YO62 6TJ";

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.isStaff = true;
            TestItem.unitQuantity = 1;
            TestItem.totalPrice = 12.3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShipAddress = "April Cottage, Lastingham, YO62 6TJ";

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;

            TestItem.isStaff = true;
            TestItem.unitQuantity = 1;
            TestItem.totalPrice = 22.3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShipAddress = "54 Highfield St, Leicester, LE2 1AD";

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);


        }

        [TestMethod]
        public void DeleteMethoOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.isStaff = true;
            TestItem.OrderID = 22;
            TestItem.unitQuantity = 1;
            TestItem.totalPrice = 12.3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShipAddress = "April Cottage, Lastingham, YO62 6TJ";

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByShipAddressMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByShipAddress("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByShipAddressNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByShipAddress("xxx xxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByShipAddressDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;

            FilteredOrders.ReportByShipAddress("Hill House, Desford, DE23 4ED");
            if(FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 2)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 50) { 
                    OK = false;

                }
         

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
