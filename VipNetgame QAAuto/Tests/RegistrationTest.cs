using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VipNetgame_QAAuto.Helpers;
using VipNetgame_QAAuto.Pages;

namespace VipNetgame_QAAuto.Tests
{
    public class RegistrationTest
    {
        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestData.MainPageURL;
        }

        [Test]
        public void RegistrationWithMail()
        {
            Random rnd = new Random();
            Registration regmail = new Registration();
            regmail.EnterRegButton.Click();
            regmail.RegistrationMail(rnd.Next().ToString() + "@mail.ru", false);
            Thread.Sleep(5000);
            StringAssert.Contains("sorty", Driver.Browser.Url);
           
        }

        [Test]
        public void RegistrationPhone()
        {
            Random rnd = new Random();
            Registration registr = new Registration();
            registr.EnterRegButton.Click();
            registr.RegistrationPhone("500508" + rnd.Next(100, 999).ToString(), true);
            Thread.Sleep(5000);
            StringAssert.Contains("sorty", Driver.Browser.Url);

        }


        [TearDown]
        public void AfterTest()
        {
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}

   