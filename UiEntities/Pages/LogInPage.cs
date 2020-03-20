using BaseUiSetup.UpgradedSelenium;
using BaseUiSetup.BasePage;
using OpenQA.Selenium;

namespace UiEntities.Pages
{
    public class LogInPage : BasePage
    {
        public UpWebElement Username => new UpWebElement(Driver, By.Name("username"));

        public UpWebElement Password => new UpWebElement(Driver, By.Name("password"));

        public UpWebElement LogInButton => new UpWebElement(Driver, By.CssSelector(".loginbtn"));


        public override string pageUrl { get; set; } = "https://www.phptravels.net/login";
    }
}
