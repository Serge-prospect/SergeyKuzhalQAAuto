using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Threading;

namespace SeleniumEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigData config = new ConfigData();

            IWebDriver driver = config.Driver;

            /* Set driver window position and size, if you need. */
            //config.SetDriverWindow();

            LoginPage senderLoginPage = LoginPage.GoToLoginPage(config);

            MailPage senderMailPage = senderLoginPage.Login(config.SenderUsername, config.SenderPassword);

            ComposerContainer composerContainer = senderMailPage.StartNewMessage();
            composerContainer.SendNewEmail(config.ReceiverEmail, config.Subject, config.EmailMessage);

            SentPage sentPage = senderMailPage.GoToSentPage();

            Email sentEmail = sentPage.GetEmailContent(config.ReceiverEmail, config.Subject);                        
            if (new EmailComparer().Equals(config.InitialEmail, sentEmail))
                Console.WriteLine($"\n> > > Email was sent to receiver.\n");

            LoginPage receiverLoginPage = sentPage.LogOut();

            MailPage receiverMailPage = receiverLoginPage.Login(config.ReceiverUsername, config.ReceiverPassword);
            InboxPage receiverInboxPage = receiverMailPage.GoToInboxPage();

            Email receivedEmail = receiverInboxPage.GetEmailContent(config.SenderEmail, config.Subject);
            if (new EmailComparer().Equals(config.InitialEmail, receivedEmail))
                Console.WriteLine($"\n> > > Email was received from sender.\n");

            receiverInboxPage.LogOut();

            // delete mailbox data
            BoxDataCleaner.CleanInBoxData(config);
            BoxDataCleaner.CleanSentBoxData(config);

            driver.Close();
            driver.Quit();
            Thread.Sleep(1000);
        }
    }
}
