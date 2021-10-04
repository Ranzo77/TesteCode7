using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteCode7.Common
{
    public class SeleniumHelpers
    {
        public IWebElement WaitElement(ChromeDriver chromeDrive, By by, Func<By, Func<IWebDriver, IWebElement>> webElement, TimeSpan time)
        {
            try
            {
                var wait = new WebDriverWait(chromeDrive, time);
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
