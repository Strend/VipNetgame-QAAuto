using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipNetgame_QAAuto.Helpers;

namespace VipNetgame_QAAuto.Pages
{
        public class Cashbox
    {
        public IWebElement CashboxButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[2]/div[1]/div[2]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/div[2]/a"));
            }
        }

        public IWebElement CashboxPopupTakeMethod
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='payments-in-form']/div[1]/span[1]/label/div/i"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='payments-in-form']/div[1]/span[1]/label/div/i"));
            }
        }

        public IWebElement CashboxPopupInput
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='payments-in-form']/div[4]/div[2]/div/div[2]/div[1]/div[3]/div[2]/div/input"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='payments-in-form']/div[4]/div[2]/div/div[2]/div[1]/div[3]/div[2]/div/input"));
            }
        }

        public IWebElement CashboxPopuptakeBonus
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[1]"));
            }
        }
        public IWebElement CashboxPopuptakeBonusSelect
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[2]/ul/li[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormIn_bonus_id-styler']/div[2]/ul/li[2]"));
            }
        }

        public IWebElement CashboxPopupButtonpush
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='payments-in-form']/div[4]/div[2]/div/div[4]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='payments-in-form']/div[4]/div[2]/div/div[4]/button"));
            }
        }


        public IWebElement CashboxPopupnextSteppush
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popup-next-step']/div/div/div[3]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popup-next-step']/div/div/div[3]/a"));
            }
        }


        public IWebElement Paymentspage
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='master-header']/h1/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='master-header']/h1/a"));
            }
        }

        public IWebElement Cashbox200ua
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='payments-in-form']/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/div/label[4]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='payments-in-form']/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/div/label[4]"));
            }
        }
        public IWebElement CashboxPopup
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popup-frame-cash']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popup-frame-cash']"));
            }
        }

        public IWebElement CashboxPopupWithdrawButton

        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[2]"));
            }
        }
        public IWebElement CashboxPopupSelectW
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[1]/div[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[1]/div[1]"));
            }
        }
        public IWebElement CashboxPopupInputSumma
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_amount']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_amount']"));
            }
        }

        public IWebElement CashboxPopupSelectWMaster
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[2]/ul/li[6]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_output_id-styler']/div[2]/ul/li[6]"));
            }
        }


        public IWebElement CashboxPopuprequisite
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_requisite']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormOut_requisite']"));
            }
        }

        public IWebElement CashboxPopupWButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='payments-out-form']/div[6]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='payments-out-form']/div[6]/button"));
            }
        }

        public IWebElement CashboxPopupSucespay
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popup-out-success']/div/div/div[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popup-out-success']/div/div/div[2]"));
            }
        }

        public IWebElement CashboxPopupCPButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[3]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[3]"));
            }
        }

        public IWebElement CashboxPopupCPinput
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormExchange_amount_cp']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='desktop_modules_cash_models_PaymentFormExchange_amount_cp']"));
            }
        }

        public IWebElement CashboxPopupCPButtonOK
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='payments-exchange-form']/div[3]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='payments-exchange-form']/div[3]/button"));
            }
        }

        public IWebElement CashboxPopupCPchangeOK
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popup-exchange-success']/div/div/div[3]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popup-exchange-success']/div/div/div[3]/a"));
            }
        }
        public IWebElement CashboxPopupCPchangeSuccess
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popup-exchange-success']/div/div/div[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popup-exchange-success']/div/div/div[2]"));
            }
        }


        public IWebElement CashboxPopupCPchangeSuccessClose
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='popup-exchange-success']/div/div/div[3]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='popup-exchange-success']/div/div/div[3]/a"));
            }
        }


        public IWebElement BonusinFirstdepositMainpage
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[6]/div/div[2]/div[3]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[6]/div/div[2]/div[3]/a"));
            }
        }
        public IWebElement HistoryFrame
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[4]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div/div[2]/div[1]/ul/li[4]/a"));
            }
        }

    }
}

    