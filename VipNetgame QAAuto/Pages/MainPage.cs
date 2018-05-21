using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using VipNetgame_QAAuto.Helpers;

namespace VipNetgame_QAAuto.Pages
{
    public class MainPage
    {

        public IWebElement EnterButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[1]/div[1]/a[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[1]/div[1]/a[1]"));
            }
        }
        public IWebElement InputLoginMail
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_players_models_LoginForm_login']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_players_models_LoginForm_login']"));
            }
        }
        public IWebElement InputPassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_players_models_LoginForm_password']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_players_models_LoginForm_password']"));
            }
        }
        public IWebElement RemindPassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login-form-remind']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login-form-remind']"));
            }
        }
        public IWebElement EnterButtonMail
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[1]/div/div/div[1]/span[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[1]/div/div/div[1]/span[1]"));
            }
        }
        public IWebElement EnterButtonPhone
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[1]/div/div/div[1]/span[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[1]/div/div/div[1]/span[2]"));
            }
        }
        public IWebElement SelectFlagNumber
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login-form']/div[1]/div[1]/div/div"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login-form']/div[1]/div[1]/div/div"));
            }
        }

        public IWebElement FlagContainer
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='register-form']/div[1]/div[1]/div"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='register-form']/div[1]/div[1]/div"));
            }
        }

        
        public IWebElement SelectFlagUA
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='mCSB_3_container']/li[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='mCSB_3_container']/li[2]"));
            }
        }

        public IWebElement EnterButtonSubmit
        {
            get
            {
                Driver.WaitUntil(By.CssSelector("#login > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > form:nth-child(1) > div:nth-child(4) > button:nth-child(1)"));
                return Driver.Browser.FindElement(By.CssSelector("#login > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > form:nth-child(1) > div:nth-child(4) > button:nth-child(1)"));
            }
        }
        public IWebElement EnterVk
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[1]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[1]/a"));
            }
        }
        public IWebElement EnterFB
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[2]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[2]/a"));
            }
        }
        public IWebElement EnterOK
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[3]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[3]/a"));
            }
        }
        public IWebElement EnterGoogle
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[4]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[4]/a"));
            }
        }
        public IWebElement EnterTwitter
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[5]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[5]/a"));
            }
        }
        public IWebElement EnterMailru
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[6]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']/div/div/div[2]/div[2]/ul/li[6]/a"));
            }
        }

        public IWebElement RegInputMail
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_contact']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_players_models_RegisterForm_contact']"));
            }
        }



        public IWebElement PopupUkazhitevalutuVnimanieAuth
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popupCurrency']/div/div/div[2]/p[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popupCurrency']/div/div/div[2]/p[2]"));
            }
        }

        public IWebElement PopupVediteparoldlaavtorizacii
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login-social']/div/div/div[2]/div[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login-social']/div/div/div[2]/div[1]"));
            }
        }

        public IWebElement VKinputlogin
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login_submit']/div/div/input[6]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login_submit']/div/div/input[6]"));
            }
        }
        public IWebElement VKinputpassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login_submit']/div/div/input[7]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login_submit']/div/div/input[7]"));
            }
        }

        public IWebElement VKsubmitbutton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='install_allow']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='install_allow']"));
            }
        }

        public IWebElement FBinputlogin
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='email']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='email']"));
            }
        }
        public IWebElement FBinputpassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='pass']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='pass']"));
            }
        }

        public IWebElement FBsubmitbutton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='loginbutton']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='loginbutton']"));
            }
        }

        public IWebElement OKinputlogin
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='field_email']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='field_email']"));
            }
        }
        public IWebElement OKinputpassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='field_password']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='field_password']"));
            }
        }

        public IWebElement OKsubmitbutton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='mainW']/div[2]/div/div/form/div[4]/input"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='mainW']/div[2]/div/div/form/div[4]/input"));
            }
        }

        public IWebElement Googleinputlogin
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='identifierId']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='identifierId']"));
            }
        }
        public IWebElement Googleinputpassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));
            }
        }

        public IWebElement Googlesubmitbutton2
        {
            get
            {
                Driver.WaitUntil(By.Id("passwordNext"));
                return Driver.Browser.FindElement(By.Id("passwordNext"));
            }
        }
        public IWebElement Googlesubmitbutton1
        {
            get
            {
                Driver.WaitUntil(By.Id("identifierNext"));
                return Driver.Browser.FindElement(By.Id("identifierNext"));
            }
        }

        public IWebElement Twitterinputlogin
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='username_or_email']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='username_or_email']"));
            }
        }
        public IWebElement Twitterinputpassword
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='password']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='password']"));
            }
        }

        public IWebElement Twittersubmitbutton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='allow']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='allow']"));
            }
        }

        public IWebElement Mailruinputlogin
        {
            get
            {
                Driver.WaitUntil(By.Id("login"));
                return Driver.Browser.FindElement(By.Id("login"));
            }
        }
        public IWebElement Mailruinputpassword
        {
            get
            {
                Driver.WaitUntil(By.Id("password"));
                return Driver.Browser.FindElement(By.Id("password"));
            }
        }

        public IWebElement Mailrusubmitbutton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login-form']/div[2]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login-form']/div[2]/button"));
            }
        }

        public IWebElement Popupremindsuccess
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login-form-popupRemindSuccess']/div/div/div[2]/p[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login-form-popupRemindSuccess']/div/div/div[2]/p[1]"));
            }
        }

        public IWebElement BlockGamesNew
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div[2]/div[1]/div/ul/li[1]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div[2]/div[1]/div/ul/li[1]/a"));
            }
        }
        public IWebElement BlockGamesTable
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div[2]/div[1]/div/ul/li[7]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div[2]/div[1]/div/ul/li[7]/a"));
            }
        }

        public IWebElement ButtonAllgame
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='all_game']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='all_game']"));
            }
        }

        public IWebElement Jackpot_Animation_Block_Diamond
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[4]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[4]"));
            }
        }
        public IWebElement Jackpot_Animation_Block_Red
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[1]"));
            }
        }
        public IWebElement Jackpot_Animation_Block_Silver
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[2]"));
            }
        }
        public IWebElement Jackpot_Animation_Block_Gold
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[3]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='jpApp']/div[2]/div/div[2]/div[3]"));
            }
        }



        public IWebElement JackpotLastWinButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='jpApp']/div[2]/div/div[3]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='jpApp']/div[2]/div/div[3]"));
            }
        }

        public IWebElement JackpotLastWinTabble1
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='mCSB_1_container']/div/table/tr[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='mCSB_1_container']/div/table/tr[1]"));
            }
        }

        public IWebElement JackpotLastWinTabble2
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='mCSB_1_container']/div/table/tr[2]/td[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='mCSB_1_container']/div/table/tr[2]/td[2]"));
            }
        }

        public IWebElement JackpotLastWinCloseButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='JPModal']/div/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='JPModal']/div/a"));
            }
        }

        //Scroll the browser to the element's Y position
        public void Scroll_todown()
        {
            (Driver.Browser as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", 1950));
        }

        public void Scroll_center()
        {
            (Driver.Browser as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", 1300));
        }

        public void Scroll_toUp()
        {
            (Driver.Browser as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", 1));
        }


        public void MoveCursorTo(int x, int y)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveByOffset(x, y).Click().Perform();

        }
               
    }
}





