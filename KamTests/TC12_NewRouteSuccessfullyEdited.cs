using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC12_NewRouteSuccessfullyEdited : MyTestBase
    {
        [Test]
        public void RunTest_TC12_NewRouteSuccessfullyEdited()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.Route();
            Assert.IsTrue(Pages.Route.IsAt(), "The user can't access Route page.");

            Pages.AddRoute.EditRoute("AutoTestRoute");
            Pages.AddRoute.ConfirmEdit();

        }
    }
}
