using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC03_LoginWithInvalidPassword : MyTestBase
    {
        [TestCategory("Base")]
        [TestMethod]
        public void RunTest_TC03()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "test");
            Assert.IsTrue(Pages.Loginpage.IsAt(), "Error message?");

            Pages.Login.TakeScreenShot();

        }
    }
}
