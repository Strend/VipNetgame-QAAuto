using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipNetgame_QAAuto.Helpers;
using VipNetgame_QAAuto.Pages;

namespace VipNetgame_QAAuto.Tests
{
    public class AuthTest
    {
        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestData.MainPageURL;
        }

        [Test]
        public void EnterMail()
        {
            MainPage Login = new MainPage();
            //Thread.Sleep(5000);
            Login.EnterButton.Click();
            Login.InputLoginMail.SendKeys(TestData.InputLogin);
            Login.InputPassword.SendKeys(TestData.InputPassword);
            Login.EnterButtonSubmit.Click();

            Profilepage header = new Profilepage();
            StringAssert.AreEqualIgnoringCase("Выход", header.Profileheader.Text);
        }

        [Test]
        public void Remindpasswordsuccess()
        {
            MainPage rempass = new MainPage();
            rempass.EnterButton.Click();
            rempass.InputLoginMail.SendKeys(TestData.InputLoginfail);
            rempass.InputPassword.SendKeys(TestData.InputPassword);
            rempass.RemindPassword.Click();

            StringAssert.AreEqualIgnoringCase("Восстановление пароля", rempass.Popupremindsuccess.Text);
        }


        [Test]
        public void EnterPhone()
        {
            MainPage login = new MainPage();
            login.EnterButton.Click();
            login.EnterButtonPhone.Click();
            login.SelectFlagNumber.Click();
            login.SelectFlagUA.Click();
            login.InputLoginMail.Clear();
            login.InputLoginMail.SendKeys(TestData.InputNumber);
            login.InputPassword.SendKeys(TestData.InputPasswordNumber);
            login.EnterButtonSubmit.Click();
            //Thread.Sleep(5000);
            Profilepage header = new Profilepage();
            StringAssert.AreEqualIgnoringCase("Выход", header.Profileheader.Text); 
        }

        [Test]
        public void EnterVK()
        {
            MainPage vklogin = new MainPage();
            vklogin.EnterButton.Click();
            vklogin.EnterVk.Click();
            vklogin.VKinputlogin.SendKeys(TestData.VkLogin);
            vklogin.VKinputpassword.SendKeys(TestData.VkPass);
            vklogin.VKsubmitbutton.Click();

            StringAssert.AreEqualIgnoringCase("Укажите валюту аккаунта, для продолжения работы с сайтом.", vklogin.PopupUkazhitevalutuVnimanieAuth.Text);
        }

        [Test]
        public void EnterFB()
        {
            MainPage FBenter = new MainPage();
            FBenter.EnterButton.Click();
            FBenter.EnterFB.Click();
            FBenter.FBinputlogin.SendKeys(TestData.FacebookLogin);
            FBenter.FBinputpassword.SendKeys(TestData.FacebookPass);
            FBenter.FBsubmitbutton.Click();

            StringAssert.AreEqualIgnoringCase("Введите пароль для завершения авторизации", FBenter.PopupVediteparoldlaavtorizacii.Text);
        }

        [Test]
        public void EnterOK()
        {
            MainPage oklogin = new MainPage();
            oklogin.EnterButton.Click();
            oklogin.EnterOK.Click();
            oklogin.OKinputlogin.SendKeys(TestData.OkLogin);
            oklogin.OKinputpassword.SendKeys(TestData.OkPass);
            oklogin.OKsubmitbutton.Click();

            StringAssert.AreEqualIgnoringCase("Укажите валюту аккаунта, для продолжения работы с сайтом.", oklogin.PopupUkazhitevalutuVnimanieAuth.Text);
        }

        [Test]
        public void EnterGoogle()
        {
            MainPage Googlelogin = new MainPage();
            Googlelogin.EnterButton.Click();
            Googlelogin.EnterGoogle.Click();
            Googlelogin.Googleinputlogin.SendKeys(TestData.GoogleLogin);
            Googlelogin.Googlesubmitbutton1.Click();
            Googlelogin.Googleinputpassword.SendKeys(TestData.GooglePass);
            Googlelogin.Googlesubmitbutton2.Click();

            StringAssert.AreEqualIgnoringCase("Укажите валюту аккаунта, для продолжения работы с сайтом.", Googlelogin.PopupUkazhitevalutuVnimanieAuth.Text);
        }

        [Test]
        public void EnterTwitter()
        {
            MainPage Twitterlogin = new MainPage();
            Twitterlogin.EnterButton.Click();
            Twitterlogin.EnterTwitter.Click();
            Twitterlogin.Twitterinputlogin.SendKeys(TestData.TwitterLogin);
            Twitterlogin.Twitterinputpassword.SendKeys(TestData.TwitterPass);
            Twitterlogin.Twittersubmitbutton.Click();

            StringAssert.AreEqualIgnoringCase("Укажите валюту аккаунта, для продолжения работы с сайтом.", Twitterlogin.PopupUkazhitevalutuVnimanieAuth.Text);
        }

        [Test]
        public void EnterMailRu()
        {
            MainPage mailrulogin = new MainPage();
            mailrulogin.EnterButton.Click();
            mailrulogin.EnterMailru.Click();
            mailrulogin.Mailruinputlogin.SendKeys(TestData.MailRuLogin);
            mailrulogin.Mailruinputpassword.SendKeys(TestData.MailRuPass);
            mailrulogin.Mailrusubmitbutton.Click();

            Profilepage header = new Profilepage();
            StringAssert.AreEqualIgnoringCase("Выход", header.Profileheader.Text);
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

