using BaseUiSetup.DriverExtensions;
using BaseUiSetup.UpgradedSelenium;
using NUnit.Framework;

namespace TestBase
{
    public class UiTestBase : TestBase
    {
        public UpWebDriver Driver { get; set; }

        public override void BeforeEach()
        {
            base.BeforeEach();
            DriverInit();
        }

        public override void AfterEach()
        {
            DriverDispose();
            base.AfterEach();
        }

        public void DriverInit()
        {
            Driver = new DriverFactory().CreateChromeDriver();
        }

        public void DriverDispose()
        {
            Driver.Dispose();
        }
    }
}
