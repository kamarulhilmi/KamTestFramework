
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System.IO;
using Common.Reporting;

namespace Framework
{
    [TestFixture]
    public abstract class MyTestBase
    {
        public static ReportingTasks reportingTasks;
        [SetUp]
        public void TestSetup()
        {
            reportingTasks.InitializeTest();
            Browser.Initialize();
        }

        [TearDown]
        public void TestCleanUp()
        {
            reportingTasks.FinalizeTest();
            Browser.Quit();
        }

        public static void BeginExecution()
        {
            ExtentReports extentReports = ReportingManager.Instance;
            extentReports.LoadConfig(Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.FullName + "\\extent-config.xml");
            extentReports.AddSystemInfo("Browser", "Chrome");

            reportingTasks = new ReportingTasks(extentReports);
        }

        public static void ExitExecution()
        {
            reportingTasks.CleanUpReporting();
        }
    }
}
