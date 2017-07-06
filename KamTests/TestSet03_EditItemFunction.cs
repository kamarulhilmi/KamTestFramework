using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TestSet03_EditItemFunction : MyTestBase
    {
        [Test]
        public void RunTest_TC06_NewUserSuccessfullyEdited()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserManagement();
            Assert.IsTrue(Pages.UserManagement.IsAt(), "The user can't access user management page.");

            Pages.UserManagement.EditUser("AutomationTesting03");
            Pages.UserManagement.ConfirmEdit();
        }

        [Test]
        public void RunTest_TC10_UserGroupSuccessfullyEdited()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserGroup();
            Assert.IsTrue(Pages.UserGroup.IsAt(), "The user can't access User Group page.");

            Pages.UserGroup.EditUserGroup("AutomationTest03");
            Pages.UserGroup.ConfirmEdit();
        }

        [Test]
        public void RunTest_TC13_NewRouteSuccessfullyEdited()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.Route();
            Assert.IsTrue(Pages.Route.IsAt(), "The user can't access Route page.");

            Pages.AddRoute.EditRoute("AutoTestRoute");
            Pages.AddRoute.ConfirmEdit();
        }

        [Test]
        public void RunTest_TC16_NewPOISuccessfullyEdited()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.POIManagement();
            Assert.IsTrue(Pages.POIManagement.IsAt(), "The user can't access POI Management page.");

            Pages.POIManagement.EditPOI("AutoTestPOI");
            Pages.POIManagement.ConfirmEdit();
        }
    }
}
