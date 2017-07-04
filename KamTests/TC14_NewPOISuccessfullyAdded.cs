using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC14_NewPOISuccessfullyAdded : MyTestBase
    {
        public void RunTest_TC14_NewPOISuccessfullyAdded()
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
