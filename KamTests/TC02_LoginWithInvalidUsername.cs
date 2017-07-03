using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC02_LoginWithInvalidUsername : MyTestBase
    {
        [TestCategory("(1) Base")]
        [NUnit.Framework.Test]
        public void RunTest_TC02_LoginWithInvalidUsername()
        {
            Pages.Login.Goto();
            Pages.Login.Login("invalidusername", "admin");
            Assert.IsTrue(Pages.Loginpage.IsAt(), "Where is the error message?");

            Pages.Login.TakeScreenShot();

        }
    }
}
