using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC05_NewUserSuccessfullyEdited : MyTestBase
    {
        [TestCategory("Edit Function")]
        [TestMethod]
        public void RunTest_TC05()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserManagement();
            Assert.IsTrue(Pages.UserManagement.IsAt(), "The user can't access user management page.");

            Pages.UserManagement.EditUser("AutomationTesting");
            Pages.UserManagement.ConfirmEdit();

        }
    }
}
