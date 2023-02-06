using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Support
{
    public class PageBase
    {
        protected readonly IWebDriver _driver;
        protected PageBase(IWebDriver driver)
        { 
            _driver = driver;
        }

        protected void GoTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
            WaitForPageLoad();
        }

        protected void WaitForPageLoad(int timeoutseconds = 30)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, timeoutseconds));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
        protected void FillTextbox(string cssSelector, string value)
        {
            var TextBoxElement = _driver.FindElement(By.CssSelector(cssSelector));
            TextBoxElement.SendKeys(value);
        }
        protected void PressButton(string cssSelector)
        {
            var ButtonElement = _driver.FindElement(By.CssSelector(cssSelector));
            ButtonElement.Click();
        }
    }
}
