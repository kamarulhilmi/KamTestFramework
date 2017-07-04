using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC06_NewUserSuccessfullyDeleted : MyTestBase
    {
        [Test]
        public void RunTest_TC06_NewUserSuccessfullyDeleted()
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
