using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstBookStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class required
            clsBookStock ABookStock = new clsBookStock();
            //test to see if it exists
            Assert.IsNotNull(ABookStock);
        }
    }
}
