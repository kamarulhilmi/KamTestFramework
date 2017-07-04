using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC13_NewRouteSuccessfullyDelete : MyTestBase
    {
        [Test]
        public void RunTest_TC13_NewRouteSuccessfullyDelete()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.Route();
            Assert.IsTrue(Pages.Route.IsAt(), "The user can't access User Group page.");

            Pages.AddRoute.DeleteRoute("AutoTestRoute");
            Pages.AddRoute.ConfirmDelete();

        }
    }
}
