using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC06_NewUserSuccessfullyDeleted : MyTestBase
    {
        [TestCategory("Delete Function")]
        [TestMethod]
        public void RunTest_TC06()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserManagement();
            Assert.IsTrue(Pages.UserManagement.IsAt(), "The user can't access user management page.");

            Pages.UserManagement.DeleteUser("AutomationTesting");
            Pages.UserManagement.ConfirmDelete();

        }
    }
}
