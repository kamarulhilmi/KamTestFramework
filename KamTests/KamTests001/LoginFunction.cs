using NUnit.Framework;
using Framework;

namespace KamTests.KamTests001
{
    public class LoginFunction : MyTestBase
    {
        [Test]
        public void RunTest_TC01_LoginWithValidUsernamePassword()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.LogOut();
        }

        [Test]
        public void RunTest_TC02_LoginWithInvalidUsername()
        {
            Pages.Login.Goto();
            Pages.Login.Login("invalidusername", "admin");
            Assert.IsFalse(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.Login.TakeScreenShot();
        }

        [Test]
        public void RunTest_TC03_LoginWithInvalidPassword()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "test");
            Assert.IsFalse(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.Login.TakeScreenShot();
        }
    }
}
