using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using QA_WORKS_ASSESSMENT.Support.HelperObjects;
using OpenQA.Selenium.Support.UI;
using QA_WORKS_ASSESSMENT.Support.BaseClasses;

namespace QA_WORKS_ASSESSMENT.Support.PageObjects
{
    class QAWorks_ContactUs_PageObject : CorePagesOnMainRibon
    {
        public QAWorks_ContactUs_PageObject()
        {
            PageTitle = "Contact Us - QAWorks";
            PageUrl = "/contact.aspx";
            Url = BaseUrl + PageUrl;
        }
        
        //Page Elements - text input fields
        private static By name_textbox = By.XPath("//div[@id='ContactNameBox']/child::input");
        private static By email_textbox = By.XPath("//div[@id='ContactEmailBox']/child::input");
        private static By message_textarea = By.XPath("//div[@id='ContactMessageBox']/child::textarea");
        
        //Page Elements - buttons
        private static By send_button = By.XPath("//div[@id='ContactSend']/child::input");

        //Page Elements - error messages
        private static By name_required_text = By.XPath("//span[contains(text(), 'Your name is required')]");
        private static By email_required_text = By.XPath("//span[contains(text(), 'An Email address is required')]");
        private static By email_format_incorrect_text = By.XPath("//span[contains(text(), 'Invalid Email Address')]");
        private static By message_required_text = By.XPath("//span[contains(text(), 'Please type your message')]");


        //Page Object Methods
        public void EnterName(string name)
        {
            enterTextInTextbox(name, name_textbox);
        }

        public void EnterEmailAddress(string email)
        {
            enterTextInTextbox(email, email_textbox);
        }

        public void EnterMessage(string message)
        {
            enterTextInTextbox(message, message_textarea);
        }

        public void enterTextInTextbox(string text, By field)
        {
            if (string.IsNullOrEmpty(text) == false)
            {
                Driver.CurrentDriver.FindElement(field).Clear();
                Driver.CurrentDriver.FindElement(field).SendKeys(text);
            }
        }

        public void ClickSend()
        {
            Driver.CurrentDriver.FindElement(send_button).Click();
        }

        public By getEmailRequired()
        {
            return email_required_text;
        }

        public By getEmailIncorrectFormat()
        {
            return email_format_incorrect_text;
        }

        public By getNameRequired()
        {
            return name_required_text;
        }

        public By getMessageRequired()
        {
            return message_required_text;
        }
    }
}
