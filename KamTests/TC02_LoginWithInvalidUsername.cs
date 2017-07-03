using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC02_LoginWithInvalidUsername : MyTestBase
    {
        [Test]
        public void RunTest_TC02_LoginWithInvalidUsername()
        {
            Pages.Login.Goto();
            Pages.Login.Login("invalidusername", "admin");
            Assert.IsFalse(Pages.MapDashboard.IsAt(), "User can't login");

            Pages.Login.TakeScreenShot();

        }
    }
}
