using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC03_LoginWithInvalidPassword : MyTestBase
    {
        [Test]
        public void RunTest_TC03_LoginWithInvalidPassword()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "test");
            Assert.IsFalse(Pages.MapDashboard.IsAt(), "User can't login");

            Pages.Login.TakeScreenShot();

        }
    }
}
