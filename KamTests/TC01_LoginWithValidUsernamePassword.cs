using NUnit.Framework;
using Framework;

namespace KamTests
{
    public class TC01_LoginWithValidUsernamePassword : MyTestBase
    {
        [Test]
        public void RunTest_TC01_LoginWithValidUsernamePassword()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.LogOut();

        }
    }
}
