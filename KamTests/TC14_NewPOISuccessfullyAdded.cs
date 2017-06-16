using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC14_NewPOISuccessfullyAdded : MyTestBase
    {
        [TestCategory("Add Function")]
        [TestMethod]
        public void RunTest_TC14()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.POIManagement();
            Assert.IsTrue(Pages.POIManagement.IsAt(), "The user can't access POI Management page.");

            Pages.POIManagement.AddPOI();
            Assert.IsTrue(Pages.AddPOI.IsAt(), "The user can't access Add POI page");

            Pages.AddPOI.AddNewPOI(
                "AutoTestPOI",
                "Gym",
                "24 Hours & 7 Days");
            Pages.AddPOI.Confirm();

        }
    }
}
