using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC16_NewPOISuccessfullyDelete : MyTestBase
    {
        [Test]
        public void RunTest_TC16_NewPOISuccessfullyDelete()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.POIManagement();
            Assert.IsTrue(Pages.POIManagement.IsAt(), "The user can't access POI Management page.");

            Pages.POIManagement.DeletePOI("AutoTestPOI");
            Pages.POIManagement.ConfirmDelete();
        }
    }
}
