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
    class ProfilepageTest
    {
        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestData.MainPageURL;
        }


        [Test]
        public void ProfileDataInformation()
        {
            Random rnd = new Random();
            Registration regmail = new Registration();
            regmail.EnterRegButton.Click();
            regmail.RegistrationMail(rnd.Next().ToString() + "@mail.ru", false);
            Random rand = new Random();
            Profilepage data = new Profilepage();
            data.PrifileButton.Click();
            data.PrifileMyDataTab.Click();
            data.NameEnter(rand.Next().ToString() + "testsolution", false);
            data.ProfileMyDataSecondName.SendKeys(TestData.Nickname);
            data.NameNickname(rand.Next().ToString() + "testsolution", false);
            data.ProfileMyDataPlayersGender.Click();
            data.ProfileMyDataPlayersBirthDaySelect.Click();
            data.ProfileMyDataPlayerPickDaySelect.Click();
            data.ProfileMyDataPlayersBirthMonthSelect.Click();
            data.ProfileMyDataPlayerPickMonthSelect.Click();
            data.ProfileMyDataPlayersBirthYearSelect.Click();
            data.ProfileMyDataPlayerPickYearSelect.Click();
            data.ProfileMyDataPlayersСountry.Click();
            data.ProfileMyDataPlayersСountryUkraine.Click();
            data.ProfileMyDataPlayerCityInput.SendKeys(TestData.Nickname);
            data.ProfileMyDataPlayerCityAdressInput.SendKeys(TestData.Nickname);
            MainPage scroll = new MainPage();
            scroll.Scroll_center();
            data.ProfileMyDataPlayerTimezone.Click();
            data.ProfileMyDataPlayerTimezoneUkraine.Click();
            data.ProfileMyDataPlayerSelectFlagNumber.Click();
            data.ProfileMyDataPlayerSelectFlagUkraine.Click();
            data.EnterPhone("500208" + rand.Next(100, 999).ToString(), true);
            data.ProfileMyDataPlayerButtonSubmit.Click();
            StringAssert.Contains("Ваш профиль успешно сохранен.", data.ProfileMyDataPopupSuccess.Text);
            
                        
        }

        [Test]
        public void ProfileDataConfirmMail()
        {
            Random rnd = new Random();
            Registration regmail = new Registration();
            regmail.EnterRegButton.Click();
            regmail.RegistrationMail(rnd.Next().ToString() + "@mail.ru", false);
            Thread.Sleep(3000);
            Random rand = new Random();
            Profilepage data = new Profilepage();
            data.PrifileButton.Click();
            MainPage scroll = new MainPage();
            scroll.Scroll_center();
            data.ProfileMyDataSendConfirmMail.Click();
            StringAssert.Contains("Готово! Код подтверждения выслан на указанный E-Mail", data.ProfileMyDataSendConfirmMailPopupSucess.Text);
            

        }

        [Test]
        public void ProfileDataConfirmPhone()
        {
            Random rnd = new Random();
            Registration regmail = new Registration();
            regmail.EnterRegButton.Click();
            regmail.RegistrationMail(rnd.Next().ToString() + "@mail.ru", false);
            Thread.Sleep(3000);
            Random rand = new Random();
            Profilepage data = new Profilepage();
            data.PrifileButton.Click();
            MainPage scroll = new MainPage();
            scroll.Scroll_center();
            data.ProfileMyDataPlayerSelectFlagNumber.Click();
            data.ProfileMyDataPlayerSelectFlagUkraine.Click();
            data.EnterPhone("500208" + rand.Next(100, 999).ToString(), true);
            data.ProfileMyDataPlayerButtonSubmit.Click();
            data.ProfileMyDataPopupSuccessButton.Click();
            scroll.Scroll_center();
            data.ProfileMyDataSendConfirmPhone.Click();
            StringAssert.Contains("Готово! Код подтверждения выслан на указанный номер телефона", data.ProfileMyDataSendConfirmPhonePopupSucces.Text);


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


