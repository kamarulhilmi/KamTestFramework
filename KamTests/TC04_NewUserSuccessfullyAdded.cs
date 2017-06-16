using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC04_NewUserSuccessfullyAdded : MyTestBase
    {
        [TestCategory("Add Function")]
        [TestMethod]
        public void RunTest_TC04()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserManagement();
            Assert.IsTrue(Pages.UserManagement.IsAt(), "The user can't access user management page.");

            Pages.UserManagement.AddNewUser();
            Assert.IsTrue(Pages.AddNewUser.IsAt(), "The user can't access add user page");

            Pages.AddNewUser.AddUser(
                "AutomationTest",
                "Test Engineer",
                "kamarulhilmi@recogine.com",
                "Damansara",
                "AutomationTesting", //username
                "Operation", //usergroupName
                "auto", //password
                "Female",
                "0135906715",
                "1991/01/05",
                "auto"
                );

            Pages.UserManagement.AddNewUserConfirm();
        }
    }
}
