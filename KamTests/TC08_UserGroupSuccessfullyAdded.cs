using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC08_UserGroupSuccessfullyAdded : MyTestBase
    {
        [Test]
        public void RunTest_TC08_UserGroupSuccessfullyAdded()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserGroup();
            Assert.IsTrue(Pages.UserGroup.IsAt(), "The user can't access User Group page.");

            Pages.UserGroup.AddUserGroup();
            Assert.IsTrue(Pages.AddUserGroup.IsAt(), "The user can't access Add User Group page");

            Pages.AddUserGroup.AddGroup("AutomationTest01");
        }
    }
}
