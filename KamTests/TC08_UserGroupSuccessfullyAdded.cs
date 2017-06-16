using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC08_UserGroupSuccessfullyAdded : MyTestBase
    {
        [TestCategory("Add Function")]
        [TestMethod]
        public void RunTest_TC08()
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
