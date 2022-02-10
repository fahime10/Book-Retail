using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(TheCustomer);
        }
    }
}
