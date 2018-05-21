using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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
        public class MailPageTest
    {
        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestData.MainPageURL;
        }

        [Test]
        public void AllgameFiltr ()
        {
               
            MainPage allgame = new MainPage();
            allgame.BlockGamesNew.Click();
            allgame.BlockGamesTable.Click();
            allgame.ButtonAllgame.Click();
            Thread.Sleep(5000);
            StringAssert.Contains("table-games", Driver.Browser.Url);
        }

        [Test]
        public void JackPotContainer()
        {
            MainPage jackpotblock = new MainPage();
            
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Red.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Silver.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Gold.Displayed);
            Assert.NotNull(jackpotblock.Jackpot_Animation_Block_Diamond.Displayed);
        }

        [Test]
        public void JackPotWinsPopup()
        {
            MainPage Jackpot = new MainPage();

            Jackpot.Scroll_center();
            Thread.Sleep(4000);
            Jackpot.JackpotLastWinButton.Click();

            StringAssert.AreEqualIgnoringCase("Тип Ник Выигрыш Дата", Jackpot.JackpotLastWinTabble1.Text);
            StringAssert.Contains("***", Jackpot.JackpotLastWinTabble2.Text);
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
