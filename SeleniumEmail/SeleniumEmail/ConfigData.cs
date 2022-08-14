using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEmail
{
    public class ConfigData
    {
        public readonly string LoginPageUrl = "https:\\account.protonmail.com\\login";

        public readonly string SenderUsername = "send220503@protonmail.com";
        public readonly string SenderPassword = "1qaz!QAZ";
        public readonly string SenderEmail;

        public readonly string ReceiverUsername = "receive220503@protonmail.com";
        public readonly string ReceiverPassword = "1qaz!QAZ";
        public readonly string ReceiverEmail;

        public readonly string Subject = "Sub03";
        public readonly string EmailMessage = "Text03";

        public readonly Email InitialEmail;

        public readonly IWebDriver Driver = new ChromeDriver(".");
        public readonly Point WindowPosition = new Point(-1280, 100);

        public ConfigData()
        {
            SenderEmail = SenderUsername;
            ReceiverEmail = ReceiverUsername;
            InitialEmail = new Email(Subject, SenderEmail, ReceiverEmail, EmailMessage);
        }

        public void SetDriverWindow()
        {            
            Driver.Manage().Window.Position = WindowPosition;
            Driver.Manage().Window.Maximize();
        }
    }
}
