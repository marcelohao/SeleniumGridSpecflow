using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITests.PageObjects;
using UITests.Support;

namespace UITests.PageObjects
{
    public class EcommHomePage : PageBase
    {
        private const string _homepageurl = $"https://www.saucedemo.com/";

        private readonly string usernameTextBox = "input[data-test='username']";
        private readonly string passwordTextBox = "input[data-test='password']";
        private readonly string loginButton = "input[data-test='login-button']";

        public EcommHomePage(IWebDriver driver) : base(driver) 
        {
        }
        public void GoToPage()
        {
            GoTo(_homepageurl);
        }
        public void EnterCredentials(string Username, string Password)
        {
            FillTextbox(usernameTextBox, Username);
            FillTextbox(passwordTextBox, Password);
            PressButton(loginButton);
        }
    }
}
