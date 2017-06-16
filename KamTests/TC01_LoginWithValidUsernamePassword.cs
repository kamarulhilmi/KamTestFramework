using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC01_LoginWithValidUsernamePassword : MyTestBase
    {
        [TestCategory("Base")]
        [TestMethod]
        public void RunTest_TC01()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.LogOut();

        }
    }
}
