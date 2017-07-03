using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC03_LoginWithInvalidPassword : MyTestBase
    {
        [TestCategory("(1) Base")]
        [NUnit.Framework.Test]
        public void RunTest_TC03_LoginWithInvalidPassword()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "test");
            Assert.IsTrue(Pages.Loginpage.IsAt(), "Error message?");

            Pages.Login.TakeScreenShot();

        }
    }
}
