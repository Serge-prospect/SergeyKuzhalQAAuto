using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEmail
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FindElementByXPath(string xPath)
        {
            IWebElement element = null;

            var attemptCounter = 1;
            var attempts = 40;
            while (attemptCounter <= attempts)
            {
                try
                {
                    element = _driver.FindElement(By.XPath(xPath));
                }
                catch (Exception elementNotFound)
                {
                    Console.WriteLine($"\n{elementNotFound.Message}\nA new attempt after 1 sec. {attemptCounter} / {attempts}\n");
                    Thread.Sleep(1000);                    
                }
                if (element != null)
                    break;
                attemptCounter++;
            }

            if(attemptCounter > 1)
                Console.WriteLine($"\nThe element has been found:\n{xPath}\n");

            return element;
        }

        public IWebElement FindElementInIframeByXPath(string xPathInIframe, string iframeTitle)
        {
            IWebElement iframe = FindIframeByTitle(iframeTitle);

            _driver.SwitchTo().Frame(iframe);
            IWebElement element = FindElementByXPath(xPathInIframe);            
            _driver.SwitchTo().DefaultContent();

            return element;
        }

        public IWebElement FindIframeByTitle(string iframeTitle)
        {
            IWebElement iframe = null;
            var iframeXPath = $"//iframe[@title='{iframeTitle}']";
            iframe = FindElementByXPath(iframeXPath);

            return iframe;
        }
    }
}
