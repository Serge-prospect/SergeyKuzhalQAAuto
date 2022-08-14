using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEmail
{
    public class InboxPage : MailPage
    {
        public InboxPage(IWebDriver driver) : base(driver)
        { }
    }
}
