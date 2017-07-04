using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC11_NewRouteSuccessfullyAdded : MyTestBase
    {
        [Test]
        public void RunTest_TC11_NewRouteSuccessfullyAdded()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.Route();
            Assert.IsTrue(Pages.Route.IsAt(), "The user can't access Route page.");

            Pages.Route.AddRoute();
            Pages.AddRoute.AddNewRoute(
                "AutoTestRoute", //route name
                "FF17E0");          //route color
            Pages.AddRoute.Confirm();

        }
    }
}
