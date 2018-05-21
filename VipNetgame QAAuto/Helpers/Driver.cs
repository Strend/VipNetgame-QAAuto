using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace VipNetgame_QAAuto.Helpers
{
    public static class Driver
    {
        private static WebDriverWait browserWait;

        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }


        public static void WaitUntil(By locator)
        {
            Driver.browserWait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    Driver.Browser = new FirefoxDriver();
                    break;
                case BrowserTypes.InternetExplorer:
                    Driver.Browser = new InternetExplorerDriver();
                    break;
                case BrowserTypes.Chrome:
                    Driver.Browser = new ChromeDriver();
                    break;
                case BrowserTypes.Edge:
                    Driver.Browser = new EdgeDriver();
                    break;
                default:
                    Driver.Browser = new ChromeDriver();
                    break;
            }
            BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(defaultTimeOut));
        }

        public static void DisposeBrowser()
        {
            Browser?.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
