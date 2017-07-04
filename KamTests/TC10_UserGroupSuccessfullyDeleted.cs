using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC10_UserGroupSuccessfullyDeleted : MyTestBase
    {
        [Test]
        public void RunTest_TC10_UserGroupSuccessfullyDeleted()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserGroup();
            Assert.IsTrue(Pages.UserGroup.IsAt(), "The user can't access User Group page.");

            Pages.UserGroup.DeleteUserGroup("AutomationTest01");
            Pages.UserGroup.ConfirmDelete();

        }
    }
}
