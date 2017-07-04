using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC09_UserGroupSuccessfullyEdited : MyTestBase
    {
        [Test]
        public void RunTest_TC09_UserGroupSuccessfullyEdited()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserGroup();
            Assert.IsTrue(Pages.UserGroup.IsAt(), "The user can't access User Group page.");

            Pages.UserGroup.EditUserGroup("AutomationTest01");
            Pages.UserGroup.ConfirmEdit();

        }
    }
}
