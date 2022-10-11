using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MHPractice.Controllers;


namespace MHPracticeTest
{
    [TestClass]
    public class MHPracticeTest
    {
        [TestMethod]
        public void LVRTestValid_1()
        {
            var controller = new LVRController();
            var response = controller.Get("$100000", "$50000");
            Assert.AreEqual("50.00%", response);
        }

        [TestMethod]
        public void LVRTestInvalid_1()
        {
            var controller = new LVRController();
            var response = controller.Get("Dollars", "50000");
            Assert.AreEqual("Input string was not in a correct format.", response);
        }
    }
}
