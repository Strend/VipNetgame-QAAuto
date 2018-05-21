using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipNetgame_QAAuto.Helpers;

namespace VipNetgame_QAAuto.Pages
{
    class Registration
    {
        public IWebElement RegInputMail
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_contact']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_contact']"));
            }
        }


        public IWebElement RegInputPassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_password']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_password']"));
            }
        }
        public IWebElement RegChackboxUA
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_currency_id_1-styler']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_currency_id_1-styler']"));
            }
        }
        public IWebElement RegChackboxAgree
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_agree-styler']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_agree-styler']"));
            }
        }


        public IWebElement RegButtonSubmit
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("div.hb-btn:nth-child(6) > button:nth-child(1)"));
                return Driver.Browser.FindElement(By.CssSelector("div.hb-btn:nth-child(6) > button:nth-child(1)"));
            }
        }
        public IWebElement EnterRegButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[1]/div[1]/a[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[1]/div[1]/a[2]"));
            }
        }

        public IWebElement PhoneButtonregistration
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='register']/div/div/div[2]/div[1]/div/div/div[1]/span[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='register']/div/div/div[2]/div[1]/div/div/div[1]/span[2]"));
            }
        }


        public void RegistrationMail(string login, bool all)
        {
           // Driver.Browser.Url = TestData.MainPageURL;
            RegInputMail.SendKeys(login);
            RegInputPassword.SendKeys(TestData.FacebookPass);
            RegChackboxUA.Click();
            RegChackboxAgree.Click();
            RegButtonSubmit.Click();
        }


        public void RegistrationPhone(string login, bool all)
        {
            //Driver.Browser.Url = TestData.MainPageURL + "/register/";
            PhoneButtonregistration.Click();
            MainPage phone = new MainPage();
            phone.FlagContainer.Click();
            phone.SelectFlagUA.Click();  
            RegInputMail.SendKeys(login);
            RegInputPassword.SendKeys(TestData.FacebookPass);
            RegChackboxUA.Click();
            RegChackboxAgree.Click();
            RegButtonSubmit.Click();
        }

    }
}



