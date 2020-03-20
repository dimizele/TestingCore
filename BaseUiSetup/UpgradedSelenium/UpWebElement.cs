using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using log4net;
using log4net.Config;
using Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace BaseUiSetup.UpgradedSelenium
{
    public class UpWebElement : IWrapsElement
    {
        public UpWebElement(UpWebDriver driver, By elementIdentifier)
        {
            UpDriver = driver;
            WrappedElement = UpDriver.FindElement(elementIdentifier).WrappedElement;
            ElementIdentifier = elementIdentifier;
        }

        public UpWebElement(UpWebDriver driver, IWebElement element)
        {
            UpDriver = driver;
            WrappedElement = element;
        }

        public UpWebElement(UpWebDriver driver, IWebElement element, By elementIdentifier)
        {
            UpDriver = driver;
            WrappedElement = element;
            ElementIdentifier = elementIdentifier;
        }

        public UpWebElement(UpWebDriver driver, UpWebElement element)
        {
            UpDriver = driver;
            WrappedElement = element.WrappedElement;
            ElementIdentifier = element.ElementIdentifier;
        }

        public UpWebDriver UpDriver { get; }

        public IWebElement WrappedElement { get; }

        public By ElementIdentifier { get; }

        public UpWebElement FindElement(By by)
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Finding element by locator:[{by}]");
            return new UpWebElement(UpDriver, WrappedElement.FindElement(by), by);
        }

        public ReadOnlyCollection<UpWebElement> FindElements(By by)
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Finding elements by locator:[{by}]");
            return new ReadOnlyCollection<UpWebElement>(WrappedElement.FindElements(by).Select(el => new UpWebElement(UpDriver, el, by)).ToList());
        }

        public UpWebElement Clear()
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Clearing element [{ElementIdentifier}]");
            WrappedElement.Clear();

            return this;
        }

        public UpWebElement SendKeys(string text)
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Sending [{text}] to element [{ElementIdentifier}]");
            WrappedElement.SendKeys(text);

            return this;
        }

        public UpWebElement Submit()
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Submitting element [{ElementIdentifier}]");
            WrappedElement.Submit();

            return this;
        }

        public UpWebElement Click()
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Clicking element [{ElementIdentifier}]");
            WrappedElement.Click();

            return this;
        }

        public string GetAttribute(string attributeName)
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Getting [{attributeName}] attribute for element [{ElementIdentifier}]");
            return WrappedElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Getting [{propertyName}] property for element [{ElementIdentifier}]");
            return WrappedElement.GetProperty(propertyName);
        }

        public string GetCssValue(string cssValue)
        {
            UpDriver.WaitForPageReady();
            Log.GetLogger().Info($"Getting [{cssValue}] CssValue for element [{ElementIdentifier}]");
            return WrappedElement.GetCssValue(cssValue);
        }

        public string TagName
        {
            get
            {
                UpDriver.WaitForPageReady();
                Log.GetLogger().Info($"Getting element [{ElementIdentifier}] TagName Property");
                return WrappedElement.TagName;
            }
        }

        public string Text
        {
            get
            {
                UpDriver.WaitForPageReady();
                Log.GetLogger().Info($"Getting element [{ElementIdentifier}] Text Property");
                return WrappedElement.Text;
            }
        }

        public bool Enabled
        {
            get
            {
                UpDriver.WaitForPageReady();
                Log.GetLogger().Info($"Getting element [{ElementIdentifier}] Enabled Property");
                return WrappedElement.Enabled;
            }
        }

        public bool Selected
        {
            get
            {
                UpDriver.WaitForPageReady();
                Log.GetLogger().Info($"Getting element [{ElementIdentifier}] Selected Property");
                return WrappedElement.Selected;
            }
        }

        public Point Location
        {
            get
            {
                UpDriver.WaitForPageReady();
                Log.GetLogger().Info($"Getting element [{ElementIdentifier}] Location Property");
                return WrappedElement.Location;
            }
        }

        public Size Size
        {
            get
            {
                UpDriver.WaitForPageReady();
                Log.GetLogger().Info($"Getting element [{ElementIdentifier}] Size Property");
                return WrappedElement.Size;
            }
        }

        public bool Displayed
        {
            get
            {
                UpDriver.WaitForPageReady();
                Log.GetLogger().Info($"Getting element [{ElementIdentifier}] Displayed Property");
                return WrappedElement.Displayed;
            }
        }
    }
}
