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

namespace QA_WORKS_ASSESSMENT.Support.BaseClasses
{
    /* Another Base class that inherits from the PageObject base class,
     * and also contains elements that are shared across all of the main pages
     */
    abstract class CorePagesOnMainRibon : PageObject
    {
        //Common Page Elements

        //These are the main ribbon links - common to all of the main pages
        protected static By _home_link = By.XPath("");
        protected static By _services_link = By.XPath("");
        protected static By _works_link = By.XPath("");
        protected static By _technology_link = By.XPath("");
        protected static By _prices_link = By.XPath("");
        protected static By _news_link = By.XPath("");
        protected static By _about_link = By.XPath("");
        protected static By _contact_link = By.XPath("//a[contains(text(), 'Contact')]");

        //Accessors to the inherited page elements
        public By home_link { get { return _home_link; } }
        public By contact_link { get { return _contact_link; } }
        public By services_link { get { return _services_link; } }
        public By works_link { get { return _works_link; } }
        public By technology_link { get { return _technology_link; } }
        public By prices_link { get { return _prices_link; } }
        public By news_link { get { return _news_link; } }
        public By about_link { get { return _about_link; } }

        //These are the main links found at the bottom of all the pages - (common)
        protected static By _enquire_by_email = By.CssSelector("div[id='EmailIcon']");
        protected static By _apply_for_position = By.XPath("//a[contains(text(), 'Apply for')]");

        //Accessors to the inherited bottom of page links
        public By enquire_by_email { get { return _enquire_by_email; } }
        public By apply_for_position { get { return _apply_for_position; } }

        //Common methods - to interact with the common variables
        public void ClickLink(By linkToNextPage)
        {
            Driver.CurrentDriver.FindElement(linkToNextPage).Click();
        }
    }
}
