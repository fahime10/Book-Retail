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
            //create an instance of the new class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists

            Assert.IsNotNull(AnOrder);
        }
    }
}
