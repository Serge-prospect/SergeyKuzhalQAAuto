using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEmail
{
    public class LoginPage : BasePage
    {        
        const string USERNAME_INPUT_XPATH = "//input[@id='username']";
        const string PASSWORD_INPUT_XPATH = "//input[@id='password']";
        const string STAYSIGNEDIN_CHECKBOX_XPATH = "//input[@id='staySignedIn']";
        const string SUBMIT_BUTTON_XPATH = "//button[@type='submit']";
                
        Dictionary<string, IWebElement> _elementCollection;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            var usernameInput = FindElementByXPath(USERNAME_INPUT_XPATH);
            var passwordInput = FindElementByXPath(PASSWORD_INPUT_XPATH);
            var staySignedInCheckBox = FindElementByXPath(STAYSIGNEDIN_CHECKBOX_XPATH);
            var submitButton = FindElementByXPath(SUBMIT_BUTTON_XPATH);

            _elementCollection = new Dictionary<string, IWebElement>()
            {
                ["username"] = usernameInput,
                ["password"] = passwordInput,
                ["stay signed in"] = staySignedInCheckBox,
                ["submit"] = submitButton
            };
        }

        public MailPage Login(string username, string password)
        {
            _elementCollection["username"]?.SendKeys(username);
            _elementCollection["password"]?.SendKeys(password);
            _elementCollection["stay signed in"]?.Click();
            Thread.Sleep(500);
            _elementCollection["submit"]?.Click();
            Thread.Sleep(500);

            return new MailPage(_driver);
        }

        public static LoginPage GoToLoginPage(ConfigData config)
        {
            config.Driver.Url = config.LoginPageUrl;
            config.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            return new LoginPage(config.Driver);
        }
    }
}
