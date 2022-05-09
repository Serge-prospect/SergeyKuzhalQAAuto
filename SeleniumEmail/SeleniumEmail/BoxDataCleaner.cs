using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEmail
{
    public static class BoxDataCleaner
    {
        public static LoginPage CleanInBoxData(ConfigData config)
        {
            LoginPage loginPage = LoginPage.GoToLoginPage(config);
            MailPage mailPage = loginPage.Login(config.ReceiverUsername, config.ReceiverPassword);
            InboxPage inboxPage = mailPage.GoToInboxPage();
            inboxPage.MoveToTrash(config.SenderEmail, config.Subject);

            return inboxPage.LogOut();
        }

        public static LoginPage CleanSentBoxData(ConfigData config)
        {
            LoginPage loginPage = LoginPage.GoToLoginPage(config);
            MailPage inboxPage = loginPage.Login(config.SenderUsername, config.SenderPassword);
            SentPage sentPage = inboxPage.GoToSentPage();
            sentPage.MoveToTrash(config.ReceiverEmail, config.Subject);

            return sentPage.LogOut();
        }
    }
}
