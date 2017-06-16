using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC13_NewRouteSuccessfullyDelete : MyTestBase
    {
        [TestCategory("Delete Function")]
        [TestMethod]
        public void RunTest_TC13()
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
