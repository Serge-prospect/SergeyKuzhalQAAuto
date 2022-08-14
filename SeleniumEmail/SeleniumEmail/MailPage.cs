using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEmail
{
    public class MailPage : BasePage
    {        
        const string NEW_MESSAGE_BUTTON_XPATH = "//button[@data-testid='sidebar:compose']";
        const string INBOX_PAGE_BUTTON_XPATH = "//a[@data-testid='navigation-link:Inbox']";
        const string SENT_PAGE_BUTTON_XPATH = "//a[@data-testid='navigation-link:Sent']";
        const string MOVE_TO_TRASH_BUTTON_XPATH = "//button[@data-testid='toolbar:movetotrash']";
        const string PROFILE_BUTTON_XPATH = "//button[@data-testid='heading:userdropdown']";
        const string LOGOUT_BUTTON_XPATH = "//button[@data-testid='userdropdown:button:logout']";
        const string MESSAGE_IFRAME_TITLE = "Email content";

        Dictionary<string, IWebElement> Elements { get; }

        public MailPage(IWebDriver driver) : base(driver)
        {
            var newMessageButton = FindElementByXPath(NEW_MESSAGE_BUTTON_XPATH);
            var inboxPageButton = FindElementByXPath(INBOX_PAGE_BUTTON_XPATH);
            var sentPageButton = FindElementByXPath(SENT_PAGE_BUTTON_XPATH);
            var moveToTrashButton = FindElementByXPath(MOVE_TO_TRASH_BUTTON_XPATH);
            var profileButton = FindElementByXPath(PROFILE_BUTTON_XPATH);

            Elements = new Dictionary<string, IWebElement>()
            {
                ["new message"] = newMessageButton,
                ["inbox page"] = inboxPageButton,
                ["sent page"] = sentPageButton,
                ["move to trash"] = moveToTrashButton,
                ["profile"] = profileButton
            };
        }
                
        public ComposerContainer StartNewMessage()
        {
            Elements["new message"]?.Click();
            Thread.Sleep(500);

            return new ComposerContainer(_driver);
        }

        public InboxPage GoToInboxPage()
        {
            Elements["inbox page"]?.Click();
            Thread.Sleep(500);

            return new InboxPage(_driver);
        }

        public SentPage GoToSentPage()
        {
            Elements["sent page"]?.Click();
            Thread.Sleep(500);

            return new SentPage(_driver);
        }

        public IWebElement GetEmailItemButton(string email, string subject)
        {
            var emailItemButtonXpath =
                "//div[@data-shortcut-target='item-container']" +
                    $"[.//span[@data-testid='message-column:sender-address'][@title='{email}']" +
                        $" and .//span[@data-testid='message-column:subject'][@title='{subject}']" +
                    "]";

            var emailItemButton = FindElementByXPath(emailItemButtonXpath);

            return emailItemButton;
        }

        public void MoveToTrash(string emailSearchKey, string subjectSearchKey)
        {
            var emailItemCheckboxXPAth =
                "//input[@type='checkbox']" +
                    "[../ancestor::div[@data-shortcut-target='item-container']" +
                        $"[.//span[@data-testid='message-column:sender-address'][@title='{emailSearchKey}']" +
                            $" and .//span[@data-testid='message-column:subject'][@title='{subjectSearchKey}']" +
                        "]" +
                    "]";

            var emailItemCheckbox = FindElementByXPath(emailItemCheckboxXPAth);
            emailItemCheckbox?.Click();
            Thread.Sleep(500);

            Elements["move to trash"]?.Click();
            Thread.Sleep(500);

            Console.WriteLine($"\n> > > Email {emailSearchKey} with subject \"{subjectSearchKey}\" was moved to trash.\n");
        }

        public LoginPage LogOut()
        {
            Elements["profile"]?.Click();
            Thread.Sleep(500);

            var logoutButton = FindElementByXPath(LOGOUT_BUTTON_XPATH);
            logoutButton?.Click();
            Thread.Sleep(500);

            Console.WriteLine($"\n> > > User is logged out.\n");

            return new LoginPage(_driver);
        }

        public Email GetEmailContent(string emailSearchKey, string subjectSearchKey)
        {
            var emailContentSubjectXPath = "//h1[@data-testid='conversation-header:subject']/span[last()]";
            var emailContentFromXPath = "//span[contains(@class,'message-recipient-item-address')]";
            var emailContentToXPath = "//div[@id='message-recipients']//span[@class='message-recipient-item-label']";
            var emailContentMessageXPath = "//div[1][contains(@style,'font-family')]";       

            GetEmailItemButton(emailSearchKey, subjectSearchKey)?.Click();
            Thread.Sleep(500);

            var emailContentSubject = FindElementByXPath(emailContentSubjectXPath).Text;
            var emailContentFrom = FindElementByXPath(emailContentFromXPath).Text;
            var emailContentTo = FindElementByXPath(emailContentToXPath).Text;

            _driver.SwitchTo().Frame(FindIframeByTitle(MESSAGE_IFRAME_TITLE));
            var emailContentMessage = FindElementByXPath(emailContentMessageXPath).Text;
            _driver.SwitchTo().DefaultContent();

            var emailContent = new Email(emailContentSubject, emailContentFrom, emailContentTo, emailContentMessage);

            return emailContent;
        }
    }
}
