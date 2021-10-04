using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TesteCode7.Common
{
    public class InitializeChromeDriver
    {
        ChromeDriver ChromeDriver;

        public InitializeChromeDriver(string URL)
        {
            this.ChromeDriver = StartChromeDriver(URL);
            this.ChromeDriver.Navigate().GoToUrl(URL);
            this.ChromeDriver.Manage().Window.Maximize();
        }

        private ChromeDriver StartChromeDriver(string URL)
        {
            var chromeDriver = new ChromeDriver();

            return chromeDriver;
        }

        public ChromeDriver GetChromeDriver()
            => ChromeDriver;

        public void CloseChromeDriver()
        {
            ChromeDriver.Close();
        }


        public IWebElement WaitElement(By by, Func<By, Func<IWebDriver, IWebElement>> webElement, TimeSpan time)
        {
            try
            {
                var wait = new WebDriverWait(GetChromeDriver(), time);
                var element = wait.Until(webElement(by));
                return element;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
