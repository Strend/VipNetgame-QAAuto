using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using VipNetgame_QAAuto.Helpers;

namespace VipNetgame_QAAuto.Pages
{
    class Profilepage
    {
        public IWebElement Profileheader
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div/div[1]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div/div[1]/a"));
            }
        }


        public IWebElement PrifileButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[2]/div[1]/div[1]/ul/li/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/div[1]/ul/li/a"));
            }
        }

        public IWebElement PrifileMyDataTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div/div[3]/ul/li[3]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div[1]/div/div[3]/ul/li[3]/a"));
            }
        }
        public IWebElement ProfileMyDataName
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_name"));
                return Driver.Browser.FindElement(By.Id("Players_name"));
            }
        }
        public IWebElement ProfileMyDataSecondName
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_surname"));
                return Driver.Browser.FindElement(By.Id("Players_surname"));
            }
        }
        public IWebElement ProfileMyDataNickname
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_nickname"));
                return Driver.Browser.FindElement(By.Id("Players_nickname"));
            }
        }
        public IWebElement ProfileMyDataPlayersGender
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_gender_id_0-styler"));
                return Driver.Browser.FindElement(By.Id("Players_gender_id_0-styler"));
            }
        }
        public IWebElement ProfileMyDataPlayersBirthDaySelect
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_birth_day-styler']/div[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_day-styler']/div[1]"));
            }
        }
        public IWebElement ProfileMyDataPlayersBirthMonthSelect
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("#Players_birth_month-styler > div:nth-child(2)"));
                return Driver.Browser.FindElement(By.CssSelector("#Players_birth_month-styler > div:nth-child(2)"));
            }
        }
        public IWebElement ProfileMyDataPlayersBirthYearSelect
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("#Players_birth_year-styler > div:nth-child(2)"));
                return Driver.Browser.FindElement(By.CssSelector("#Players_birth_year-styler > div:nth-child(2)"));
            }
        }
        public IWebElement ProfileMyDataPlayerPickDaySelect
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_birth_day-styler']/div[2]/ul/li[3]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_birth_day-styler']/div[2]/ul/li[3]"));
            }
        }
        public IWebElement ProfileMyDataPlayerPickMonthSelect
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("#Players_birth_month-styler > div:nth-child(3) > ul:nth-child(3) > li:nth-child(2)"));
                return Driver.Browser.FindElement(By.CssSelector("#Players_birth_month-styler > div:nth-child(3) > ul:nth-child(3) > li:nth-child(2)"));
            }
        }
        public IWebElement ProfileMyDataPlayerPickYearSelect
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("#Players_birth_year-styler > div:nth-child(3) > ul:nth-child(3) > li:nth-child(5)"));
                return Driver.Browser.FindElement(By.CssSelector("#Players_birth_year-styler > div:nth-child(3) > ul:nth-child(3) > li:nth-child(5)"));
            }
        }

        public IWebElement ProfileMyDataPlayerButtonSubmit
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='profile-form']/div[2]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='profile-form']/div[2]/button"));
            }
        }

        public IWebElement ProfileMyDataPlayerSelectFlagNumber
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='profile-form']/div[1]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='profile-form']/div[1]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div"));
            }
        }
        public IWebElement ProfileMyDataPlayerSelectFlagUkraine
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='mCSB_1_container']/li[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='mCSB_1_container']/li[2]"));
            }
        }

        public IWebElement ProfileMyDataPlayersСountry
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("#Players_country_id-styler > div.jq-selectbox__select > div.jq-selectbox__select-text.placeholder"));
                return Driver.Browser.FindElement(By.CssSelector("#Players_country_id-styler > div.jq-selectbox__select > div.jq-selectbox__select-text.placeholder"));
            }
        }

        public IWebElement ProfileMyDataPlayersСountryUkraine
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_country_id-styler']/div[2]/ul/li[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_country_id-styler']/div[2]/ul/li[2]"));
            }
        }

        public IWebElement ProfileMyDataPlayerCityInput
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_city"));
                return Driver.Browser.FindElement(By.Id("Players_city"));
            }
        }
        public IWebElement ProfileMyDataPlayerCityAdressInput
        {
            get
            {
                Driver.WaitUntil(By.Id("Players_address"));
                return Driver.Browser.FindElement(By.Id("Players_address"));
            }
        }
        public IWebElement ProfileMyDataPlayerTimezoneUkraine
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("li.option:nth-child(3)"));
                return Driver.Browser.FindElement(By.CssSelector("li.option:nth-child(3)"));
            }
        }

        public IWebElement ProfileMyDataPlayerTimezone
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("#Players_timezone-styler > div:nth-child(2) > div:nth-child(1)"));
                return Driver.Browser.FindElement(By.CssSelector("#Players_timezone-styler > div:nth-child(2) > div:nth-child(1)"));
            }
        }

        public IWebElement ProfileMyDataPlayerPhoneInput
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='Players_phone']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='Players_phone']"));
            }
        }

        public IWebElement ProfileMyDataPopupSuccess
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popup-profile-success']/div/div/div[2]/p"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popup-profile-success']/div/div/div[2]/p"));
            }
        }

        public void NameEnter (string nickname, bool all)
        {
            ProfileMyDataName.SendKeys(nickname);

        }
        public void NameNickname(string nickname, bool all)
        {
            ProfileMyDataNickname.SendKeys(nickname);

        }
        public void EnterPhone(string Phone, bool all)
        {
            ProfileMyDataPlayerPhoneInput.SendKeys(Phone);

        }


    }
}


