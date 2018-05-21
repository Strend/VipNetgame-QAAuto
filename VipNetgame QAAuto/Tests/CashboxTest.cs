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
    class CashboxTest
    {
        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestData.MainPageURL;
        }


        [Test]
        public void PopolnenieCasa()
        {
            MainPage Login = new MainPage();
            //Thread.Sleep(5000);
            Login.EnterButton.Click();
            Login.InputLoginMail.SendKeys(TestData.InputLogin);
            Login.InputPassword.SendKeys(TestData.InputPassword);
            Login.EnterButtonSubmit.Click();
            Cashbox replish = new Cashbox();
            replish.CashboxButton.Click();
            replish.CashboxPopup.Click();
            Driver.Browser.SwitchTo().Frame("frame-cash");
            Thread.Sleep(2000);
            replish.Cashbox200ua.Click();
            Thread.Sleep(2000);
            replish.CashboxPopupTakeMethod.Click();
            replish.CashboxPopupInput.Click();
            replish.CashboxPopupInput.Clear();
            replish.CashboxPopupInput.SendKeys(TestData.Payments);
            replish.CashboxPopuptakeBonus.Click();
            replish.CashboxPopuptakeBonusSelect.Click();
            replish.CashboxPopupButtonpush.Click();
            replish.CashboxPopupnextSteppush.Click();
            Driver.Browser.SwitchTo().Window(Driver.Browser.WindowHandles[1]);
            StringAssert.AreEqualIgnoringCase("W1 - Единая касса", replish.Paymentspage.Text);

        }


        [Test]
        public void VivodCasa()
        {
            MainPage Login = new MainPage();
            Login.EnterButton.Click();
            Login.InputLoginMail.SendKeys(TestData.InputLogin);
            Login.InputPassword.SendKeys(TestData.InputPassword);
            Login.EnterButtonSubmit.Click();
            Cashbox replish = new Cashbox();
            replish.CashboxButton.Click();
            Driver.Browser.SwitchTo().Frame("frame-cash");
            replish.CashboxPopupWithdrawButton.Click();
            replish.CashboxPopupSelectW.Click();
            replish.CashboxPopupSelectWMaster.Click();
            replish.CashboxPopupInputSumma.Click();
            replish.CashboxPopupInputSumma.SendKeys(TestData.Payments);
            replish.CashboxPopuprequisite.Clear();
            replish.CashboxPopuprequisite.SendKeys(TestData.CreditCardVisa);
            replish.CashboxPopupWButton.Click();
            StringAssert.AreEqualIgnoringCase("Заявка на выплату отправлена. Она будет обработана в течение 3-х часов.", replish.CashboxPopupSucespay.Text);

        }

        [Test]
        public void CPChange()
        {
            MainPage Login = new MainPage();
            //Thread.Sleep(5000);
            Login.EnterButton.Click();
            Login.InputLoginMail.SendKeys(TestData.InputLogin);
            Login.InputPassword.SendKeys(TestData.InputPassword);
            Login.EnterButtonSubmit.Click();
            Cashbox replish = new Cashbox();
            replish.CashboxButton.Click();
            Driver.Browser.SwitchTo().Frame("frame-cash");
            replish.CashboxPopupCPButton.Click();
            replish.CashboxPopupCPinput.SendKeys("40");
            replish.CashboxPopupCPButtonOK.Click();
            StringAssert.AreEqualIgnoringCase("На ваш баланс зачислено 2 UAH за 40 cp", replish.CashboxPopupCPchangeSuccess.Text);
            replish.CashboxPopupCPchangeOK.Click();

        }


        [Test]
        public void OtmenaViplati()
        {
            MainPage Login = new MainPage();
            //Thread.Sleep(5000);
            Login.EnterButton.Click();
            Login.InputLoginMail.SendKeys(TestData.InputLogin);
            Login.InputPassword.SendKeys(TestData.InputPassword);
            Login.EnterButtonSubmit.Click();
            Cashbox replish = new Cashbox();
            replish.CashboxButton.Click();
            Driver.Browser.SwitchTo().Frame("frame-cash");


            replish.CashboxPopupCPButton.Click();
            replish.CashboxPopupCPinput.SendKeys("40");
            replish.CashboxPopupCPButtonOK.Click();
            StringAssert.AreEqualIgnoringCase("На ваш баланс зачислено 2 UAH за 40 cp", replish.CashboxPopupCPchangeSuccess.Text);
            replish.CashboxPopupCPchangeOK.Click();

        }



        [TearDown]
        public void AfterTest()
        {
            Profilepage profile = new Profilepage();
            //profile.Logout(Driver.Browser);
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}

