using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumEmail;
using System.Threading;

namespace SeleniumEmailTests
{
    [TestClass]
    public class C_CleanTestData
    {
        readonly ConfigData _config;
        public C_CleanTestData()
        {
            _config = new ConfigData();
        }

        [TestMethod]
        public void CleanInBoxTestData()
        {
            IWebDriver driver = _config.Driver;

            /* Set driver window position and size, if you need. */
            //_config.SetDriverWindow();

            Assert.IsNotNull(BoxDataCleaner.CleanInBoxData(_config), "There is no such email in the Inbox.");

            driver.Close();
            driver.Quit();
            Thread.Sleep(1000);
        }

        [TestMethod]
        public void CleanSentBoxTestData()
        {
            IWebDriver driver = _config.Driver;

            /* Set driver window position and size, if you need. */
            //_config.SetDriverWindow();

            Assert.IsNotNull(BoxDataCleaner.CleanSentBoxData(_config), "There is no such email in the Sentbox.");

            driver.Close();
            driver.Quit();
            Thread.Sleep(1000);
        }
    }
}
