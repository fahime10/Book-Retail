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


    }
}
