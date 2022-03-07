using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarLtdTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //An instance of the class to be created
            clsStaff AStaff = new clsStaff();
            //Test to see that it exists
            Assert.IsNotNull(AStaff);
        }
    }

    class clsStaff
    {
    }
}
