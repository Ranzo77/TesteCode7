using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TesteCode7.Common;

namespace TesteCode7
{
    public class ContatoCode7 : SeleniumHelpers
    {
        private IWebElement SelectContactButton(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.XPath("//a[@title='Contato' and contains(text(), 'Contato')]"), 
                ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//a[@title='Contato' and contains(text(), 'Contato')]"));
        }

        private IWebElement SelectAcceptCokkiesButton(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.XPath("//div[@class='cookie-consent-accept']"), ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//div[@class='cookie-consent-accept']"));
        }

        private IWebElement SelectNameField(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.Name("nome"), ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.Name("nome"));
        }

        private IWebElement SelectEmailField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Name("email"));

        private IWebElement SelectCompanyField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Name("empresa"));

        private IWebElement SelectPhoneNumberField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Name("telefone"));

        private IWebElement SelectQuantityAttendants(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//div[@class='btn-open radio']"));

        private IWebElement SelectQuantityAttendantsNumber(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//span[@class='wpcf7-list-item-label' and contains(text(), '3 a 10')]"));

        private IWebElement SelectOptionSolution(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//div[@class='btn-open check']"));

        private IWebElement SelectGetOptionSolution(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.XPath("//span[@class='wpcf7-list-item-label' and contains(text(), 'Code7 Omni')]"), 
                ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//span[@class='wpcf7-list-item-label' and contains(text(), 'Code7 Omni')]"));
        }

        private IWebElement SelectHelpMessage(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//span[@class='wpcf7-form-control-wrap mensagem']"));

        private IWebElement SelectTextMessageField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Name("mensagem"));

        private IWebElement SelectSendMessage(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//input[@type='submit'][@value='Enviar mensagem']"));

        private IWebElement SelectContatoImage(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//div[@class='wpb_wrapper']//h1[@class='title--large title--bright']"));

        public void ClickSelectContactButton(InitializeChromeDriver initializeChromeDriver) { SelectContactButton(initializeChromeDriver).Click(); }

        public void ClickSelectAcceptCokkiesButton(InitializeChromeDriver initializeChromeDriver) { SelectAcceptCokkiesButton(initializeChromeDriver).Click(); }

        public void ClickSelectNameField(InitializeChromeDriver initializeChromeDriver, string name) 
        {
            SelectNameField(initializeChromeDriver).Click();
            SelectNameField(initializeChromeDriver).SendKeys(name);
        }

        public void ClickSelectEmailFiled(InitializeChromeDriver initializeChromeDriver, string email)
        {
            SelectEmailField(initializeChromeDriver).Click();
            SelectEmailField(initializeChromeDriver).SendKeys(email);
        }

        public void ClickSelectCompanyField(InitializeChromeDriver initializeChromeDriver)
        {
            SelectCompanyField(initializeChromeDriver).Click();
            SelectCompanyField(initializeChromeDriver).SendKeys("Particular");
        }

        public void ClickSelectPhoneNumberField(InitializeChromeDriver initializeChromeDriver, string phoneNumber)
        {
            SelectPhoneNumberField(initializeChromeDriver).Click();
            SelectPhoneNumberField(initializeChromeDriver).SendKeys(phoneNumber);
        }

        public void ClickSelectAttendantsQuantity(InitializeChromeDriver initializeChromeDriver)
        {
            SelectQuantityAttendants(initializeChromeDriver).Click();
            SelectQuantityAttendantsNumber(initializeChromeDriver).Click();
        }

        public void ClickSelectInterestSolution(InitializeChromeDriver initializeChromeDriver)
        {
            SelectOptionSolution(initializeChromeDriver).Click();
            SelectGetOptionSolution(initializeChromeDriver).Click();
            SelectOptionSolution(initializeChromeDriver).Click();
        }

        public void ClickSelectHelpMessage(InitializeChromeDriver initializeChromeDriver) 
        { 
            SelectHelpMessage(initializeChromeDriver).Click();
            SelectTextMessageField(initializeChromeDriver).SendKeys("Isso é um teste para vaga de automação de testes criada pela Code7. Favor desconsiderar!");
        }

        public void ClickSendMessage(InitializeChromeDriver initializeChromeDriver) 
        { 
            var htmlElement = SelectSendMessage(initializeChromeDriver);
            Actions action = new Actions(initializeChromeDriver.GetChromeDriver());

            action.MoveToElement(htmlElement);
            action.Perform();
            SelectSendMessage(initializeChromeDriver).Click();
        }
    }
}
