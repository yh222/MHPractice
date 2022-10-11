using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MHPractice;

namespace MHPracticeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Controller()
        {
            var controller = new Controllers.LVRController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var response = controller.Get(100000,50000);
            Assert.AreEqual(0.5, response.TryGetContentValue());
        }
    }
}
