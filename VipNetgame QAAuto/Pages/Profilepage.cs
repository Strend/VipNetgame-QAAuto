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
    }
}


