using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TesteCode7.Common;

namespace TesteCode7
{
    public class GoogleAccountCreate : SeleniumHelpers
    {
        private IWebElement SelectFirstNameField(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.Id("firstName") ,ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.Id("firstName"));
        }

        private IWebElement SelectLastNameField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Id("lastName"));

        private IWebElement SelectUserNameField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Id("username"));

        private IWebElement SelectKeyField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Name("Passwd"));

        private IWebElement SelectConfirmKeyField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Name("ConfirmPasswd"));

        private IWebElement SelectNextStepButton(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d' and contains (text(), 'Próxima')]"));

        private IWebElement SelectPhoneNumberField(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.Id("phoneNumberId"), ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.Id("phoneNumberId"));
        }

        private IWebElement SelectValidateCodeField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Id("code"));

        private IWebElement SelectCheckButton(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d' and contains (text(), 'Verificar')]"));

        private IWebElement SelectBirthDayField(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.Id("day"), ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.Id("day"));
        }

        private IWebElement SelectMonthField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Id("month"));

        private IWebElement SelectYearField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Id("year"));

        private IWebElement SelectGenderField(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Id("gender"));

        private IWebElement SelectScapeButton(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.XPath("//span[@class='VfPpkd-vQzf8d' and contains (text(), 'Pular')]"), 
                ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d' and contains (text(), 'Pular')]"));
        }

        private IWebElement SelectGoogleTermsServiceAgree(InitializeChromeDriver initializeChromeDriver)
        {
            return initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//input[@class='VfPpkd-muHVFf-bMcfAe'][@id='c13']"));
        }

        private IWebElement SelectGooglePersonalUserDataAgreement(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//input[@class='VfPpkd-muHVFf-bMcfAe'][@id='c17']"));

        private IWebElement SelectCreateAccountButton(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d' and contains(text(), 'Criar conta')]"));

        private IWebElement SelectUserPerfil(InitializeChromeDriver initializeChromeDriver)
        {
            WaitElement(initializeChromeDriver.GetChromeDriver(), By.XPath("//img[@class='gb_Ca gbii']"), ExpectedConditions.ElementIsVisible, TimeSpan.FromSeconds(5));
            return initializeChromeDriver.GetChromeDriver().FindElement(By.XPath("//img[@class='gb_Ca gbii']"));
        }

        private IWebElement SelectExitButton(InitializeChromeDriver initializeChromeDriver)
            => initializeChromeDriver.GetChromeDriver().FindElement(By.Id("gb_71"));

        public void ClickTypeFirstNameField(InitializeChromeDriver initializeChromeDriver, string firstName)
        {
            SelectFirstNameField(initializeChromeDriver).Click();
            SelectFirstNameField(initializeChromeDriver).SendKeys(firstName);
        }

        public void ClickTypeLastNameField(InitializeChromeDriver initializeChromeDriver, string lastName)
        {
            SelectLastNameField(initializeChromeDriver).Click();
            SelectLastNameField(initializeChromeDriver).SendKeys(lastName);
        }

        public void ClickTypeUserNameField(InitializeChromeDriver initializeChromeDriver, string userName)
        {
            SelectUserNameField(initializeChromeDriver).Click();
            SelectUserNameField(initializeChromeDriver).SendKeys(userName);
        }

        public void ClickTypeKeyField(InitializeChromeDriver initializeChromeDriver, string key)
        {
            SelectKeyField(initializeChromeDriver).Click();
            SelectKeyField(initializeChromeDriver).SendKeys(key);
        }

        public void ClickTypeConfirmKeyField(InitializeChromeDriver initializeChromeDriver, string confirmKey)
        {
            SelectConfirmKeyField(initializeChromeDriver).Click();
            SelectConfirmKeyField(initializeChromeDriver).SendKeys(confirmKey);
        }

        public void ClickNextStepButton(InitializeChromeDriver initializeChromeDriver) { SelectNextStepButton(initializeChromeDriver).Click(); }

        public void ClickTypePhoneNumberField(InitializeChromeDriver initializeChromeDriver, string phoneNumber)
        {
            Thread.Sleep(3000);
            SelectPhoneNumberField(initializeChromeDriver).Click();
            SelectPhoneNumberField(initializeChromeDriver).SendKeys(phoneNumber);
        }

        public void ClickTypeValidateCodeField(InitializeChromeDriver initializeChromeDriver, string validateCode) 
        {
            SelectValidateCodeField(initializeChromeDriver).Click();
            SelectValidateCodeField(initializeChromeDriver).SendKeys(validateCode);    
        }

        public void ClickSelectCheckButton(InitializeChromeDriver initializeChromeDriver) { SelectCheckButton(initializeChromeDriver).Click(); }

        public void ClickTypeBirthDate(InitializeChromeDriver initializeChromeDriver, DataNascimento dataNascimento)
        {
            SelectBirthDayField(initializeChromeDriver).Click();
            SelectBirthDayField(initializeChromeDriver).SendKeys(dataNascimento.Day);

            SelectMonthField(initializeChromeDriver).Click();
            SelectMonthField(initializeChromeDriver).SendKeys(dataNascimento.Month);

            SelectYearField(initializeChromeDriver).Click();
            SelectYearField(initializeChromeDriver).SendKeys(dataNascimento.Year);
        }

        public void ClickTypeGenderField(InitializeChromeDriver initializeChromeDriver, string gender)
        {
            SelectGenderField(initializeChromeDriver).Click();
            SelectGenderField(initializeChromeDriver).SendKeys(gender);
        }

        public void ClickSelectScapeButton(InitializeChromeDriver initializeChromeDriver) 
        {
            Thread.Sleep(2000);
            SelectScapeButton(initializeChromeDriver).Click(); 
        }

        public void ClickSelectGoogleTermsServiceAgree(InitializeChromeDriver initializeChromeDriver) 
        {
            Thread.Sleep(2000);

            var htmlElement = SelectGoogleTermsServiceAgree(initializeChromeDriver);
            Actions action = new Actions(initializeChromeDriver.GetChromeDriver());

            action.MoveToElement(htmlElement);
            action.Perform();

            SelectGoogleTermsServiceAgree(initializeChromeDriver).Click();
            SelectGooglePersonalUserDataAgreement(initializeChromeDriver).Click();
        }

        public void ClickSelectCreateAccountButton(InitializeChromeDriver initializeChromeDriver) { SelectCreateAccountButton(initializeChromeDriver).Click(); }

        public void ClickSelectUserPerfil(InitializeChromeDriver initializeChromeDriver) 
        {
            Thread.Sleep(2000);
            SelectUserPerfil(initializeChromeDriver).Click(); 
        }

        public void ClickSelectExitButton(InitializeChromeDriver initializeChromeDriver) { SelectExitButton(initializeChromeDriver).Click(); }
    }
}
