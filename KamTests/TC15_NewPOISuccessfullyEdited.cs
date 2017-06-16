using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace KamTests
{
    [TestClass]
    public class TC15_NewPOISuccessfullyEdited : MyTestBase
    {
        [TestCategory("Edit Function")]
        [TestMethod]
        public void RunTest_TC15()
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
