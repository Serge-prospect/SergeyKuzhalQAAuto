using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEmail
{
    public class ComposerContainer : MailPage
    {
        const string TO_EMAIL_INPUT_XPATH = "//input[@placeholder='Email address']";
        const string SUBJECT_INPUT_XPATH = "//input[@placeholder='Subject']";
        const string EDITOR_XPATH = "//div[@id='rooster-editor']/div[1]";
        const string SEND_BUTTON_XPATH = "//button[contains(@class,'composer-send-button')]";
        const string EDITOR_IFRAME_TITLE = "Email composer";

        Dictionary<string, IWebElement> _elements;

        public ComposerContainer(IWebDriver driver) : base(driver)
        {
            var toEmailInput = FindElementByXPath(TO_EMAIL_INPUT_XPATH);
            var subjectInput = FindElementByXPath(SUBJECT_INPUT_XPATH);
            var editor = FindElementInIframeByXPath(EDITOR_XPATH, EDITOR_IFRAME_TITLE);
            var sendButton = FindElementByXPath(SEND_BUTTON_XPATH);

            _elements = new Dictionary<string, IWebElement>()
            {
                ["to email"] = toEmailInput,
                ["subject"] = subjectInput,
                ["editor"] = editor,
                ["send"] = sendButton
            };
        }

        public void SendNewEmail(string toEmail, string subject, string emailMessage)
        {
            _elements["to email"]?.SendKeys(toEmail);
            _elements["subject"]?.SendKeys(subject);

            _driver.SwitchTo().Frame(FindIframeByTitle(EDITOR_IFRAME_TITLE));
            _elements["editor"]?.SendKeys(emailMessage);
            _driver.SwitchTo().DefaultContent();

            _elements["send"]?.Click();
            Thread.Sleep(500);
        }
    }
}
