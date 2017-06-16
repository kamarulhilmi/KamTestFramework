using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC10_UserGroupSuccessfullyDeleted : MyTestBase
    {
        [TestCategory("Delete Function")]
        [TestMethod]
        public void RunTest_TC10()
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
