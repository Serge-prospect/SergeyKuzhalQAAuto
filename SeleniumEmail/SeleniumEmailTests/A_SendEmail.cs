using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumEmail;
using System.Threading;

namespace SeleniumEmailTests
{
    [TestClass]
    public class A_SendEmail
    {
        readonly ConfigData _config;
        readonly Email _expectedEmail;

        public A_SendEmail()
        {
            _config = new ConfigData();
            _expectedEmail = _config.InitialEmail;
        }

        [TestMethod]
        public void SendEmailPositive()
        {
            IWebDriver driver = _config.Driver;

            /* Set driver window position and size, if you need. */
            //_config.SetDriverWindow();

            LoginPage loginPage = LoginPage.GoToLoginPage(_config);

            MailPage mailPage = loginPage.Login(_config.SenderUsername, _config.SenderPassword);

            ComposerContainer composerContainer = mailPage.StartNewMessage();

            composerContainer.SendNewEmail(_config.ReceiverEmail, _config.Subject, _config.EmailMessage);

            SentPage sentPage = mailPage.GoToSentPage();
            Email actualEmail = sentPage.GetEmailContent(_config.ReceiverEmail, _config.Subject);

            Assert.IsTrue(new EmailComparer().Equals(_expectedEmail, actualEmail), "Emial was not sent.");

            sentPage.LogOut();

            driver.Close();
            driver.Quit();
            Thread.Sleep(1000);
        }
    }
}
