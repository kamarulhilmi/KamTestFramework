using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC07_NewUserPasswordSuccessfullyReset : MyTestBase
    {
        [TestCategory("Edit Function")]
        [TestMethod]
        public void RunTest_TC07()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserManagement();
            Assert.IsTrue(Pages.UserManagement.IsAt(), "The user can't access user management page.");

            Pages.UserManagement.ResetPassword("AutomationTesting");
            Pages.UserManagement.ConfirmResetPassword();

        }
    }
}
