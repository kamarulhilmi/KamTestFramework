using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC05_NewUserSuccessfullyEdited : MyTestBase
    {
        [Test]
        public void RunTest_TC05_NewUserSuccessfullyEdited()
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
