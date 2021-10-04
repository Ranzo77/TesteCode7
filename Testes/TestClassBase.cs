using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using TesteCode7;
using TesteCode7.Common;
using TesteCode7.RapidAPI;

namespace Testes
{
    public class TestClassBase
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TC001_CreateGoogleAccount()
        {
            var googleAccountJson = new GoogleAccountJson();
            var initializeChromeDriver = new InitializeChromeDriver("https://accounts.google.com/signup/v2");
            var googleAccountCreate = new GoogleAccountCreate();

            var jsonFile = googleAccountJson.DeserializeCode7Json();

            googleAccountCreate.ClickTypeFirstNameField(initializeChromeDriver, jsonFile.FirstName);
            googleAccountCreate.ClickTypeLastNameField(initializeChromeDriver, jsonFile.LastName);
            googleAccountCreate.ClickTypeUserNameField(initializeChromeDriver, jsonFile.Email);
            googleAccountCreate.ClickTypeKeyField(initializeChromeDriver, jsonFile.Key);
            googleAccountCreate.ClickTypeConfirmKeyField(initializeChromeDriver, jsonFile.Key);
            googleAccountCreate.ClickNextStepButton(initializeChromeDriver);
            googleAccountCreate.ClickTypePhoneNumberField(initializeChromeDriver, jsonFile.PhoneNumber);
            googleAccountCreate.ClickNextStepButton(initializeChromeDriver);

            /*Informe o código de validação!*/
            var validateCode = "543290";

            googleAccountCreate.ClickTypeValidateCodeField(initializeChromeDriver, validateCode);
            googleAccountCreate.ClickSelectCheckButton(initializeChromeDriver);
            googleAccountCreate.ClickTypeBirthDate(initializeChromeDriver, jsonFile.DataNascimento[0]);
            googleAccountCreate.ClickTypeGenderField(initializeChromeDriver, jsonFile.Gender);
            googleAccountCreate.ClickNextStepButton(initializeChromeDriver);
            googleAccountCreate.ClickSelectScapeButton(initializeChromeDriver);
            googleAccountCreate.ClickSelectGoogleTermsServiceAgree(initializeChromeDriver);
            googleAccountCreate.ClickSelectCreateAccountButton(initializeChromeDriver);
            googleAccountCreate.ClickSelectUserPerfil(initializeChromeDriver);
            googleAccountCreate.ClickSelectExitButton(initializeChromeDriver);

            initializeChromeDriver.CloseChromeDriver();
        }

        [Test]
        public void TC0002_ContactCode7()
        {
            Code7Json code7Json = new Code7Json();
            var initializeChromeDriver = new InitializeChromeDriver("https://code7.com/");
            var contatoCode7 = new ContatoCode7();

            var contactInfo = code7Json.DeserializeCode7Json();

            contatoCode7.ClickSelectContactButton(initializeChromeDriver);
            contatoCode7.ClickSelectAcceptCokkiesButton(initializeChromeDriver);
            contatoCode7.ClickSelectNameField(initializeChromeDriver, contactInfo.FirstName);
            contatoCode7.ClickSelectEmailFiled(initializeChromeDriver, contactInfo.Email);
            contatoCode7.ClickSelectCompanyField(initializeChromeDriver);
            contatoCode7.ClickSelectPhoneNumberField(initializeChromeDriver, contactInfo.PhoneNumber);
            contatoCode7.ClickSelectAttendantsQuantity(initializeChromeDriver);
            contatoCode7.ClickSelectInterestSolution(initializeChromeDriver);
            contatoCode7.ClickSelectHelpMessage(initializeChromeDriver);
            contatoCode7.ClickSendMessage(initializeChromeDriver);

            Thread.Sleep(15000);

            initializeChromeDriver.CloseChromeDriver();
        }

        [Test]
        public void TC0003_GetDateFact()
        {
            var httpCommand = new HttpCommand();
            var dateFact = new DateFact();
            var bodyResponse = httpCommand.GetHttpRequestMessageContent($"{DateTime.Now.Day}/{DateTime.Now.Month}/date?fragment=true&json=true");
            var dFact = dateFact.DeserializeDateFactJson(bodyResponse.Result);

            if (string.IsNullOrEmpty(dFact.text) || string.IsNullOrEmpty(dFact.year.ToString()))
                Assert.Fail();
        }

        [Test]
        public void TC0004_GetMathFact()
        {
            var httpCommnad = new HttpCommand();
            var random = new Random();
            var integer = random.Next(1, 5000);
            var httpResponse = httpCommnad.GetHttpRequestResponseContent($"{integer}/math?fragment=true&json=true", true);

            Assert.AreEqual(System.Net.HttpStatusCode.OK, httpResponse.StatusCode);
        }

        [Test]
        public void TC005_GetRandomFact()
        {
            var httpCommand = new HttpCommand();
            var htppResponse = httpCommand.GetHttpRequestResponseContent("random/trivia?min=10&max=20&fragment=true&json=true", false);

            Assert.AreEqual(System.Net.HttpStatusCode.Unauthorized, htppResponse.StatusCode);
        }
    }
}