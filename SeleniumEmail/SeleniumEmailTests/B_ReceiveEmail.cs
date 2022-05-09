using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumEmail;
using System.Threading;

namespace SeleniumEmailTests
{
    [TestClass]
    public class B_ReceiveEmail
    {
        readonly ConfigData _config;
        readonly Email _expectedEmail;

        public B_ReceiveEmail()
        {
            _config = new ConfigData();
            _expectedEmail = _config.InitialEmail;
        }

        [TestMethod]
        public void ReceiveEmailPositive()
        {
            IWebDriver driver = _config.Driver;

            /* Set driver window position and size, if you need. */
            //_config.SetDriverWindow();

            LoginPage loginPage = LoginPage.GoToLoginPage(_config);

            MailPage mailPage = loginPage.Login(_config.ReceiverUsername, _config.ReceiverPassword);            

            InboxPage inboxPage = mailPage.GoToInboxPage();
            Email actualEmail = inboxPage.GetEmailContent(_config.SenderEmail, _config.Subject);

            Assert.IsTrue(new EmailComparer().Equals(_expectedEmail, actualEmail), "Email was not received.");

            inboxPage.LogOut();

            driver.Close();
            driver.Quit();
            Thread.Sleep(1000);
        }
    }
}
