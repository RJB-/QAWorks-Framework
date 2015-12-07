using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using QA_WORKS_ASSESSMENT.Support.HelperObjects;
using QA_WORKS_ASSESSMENT.Support.BaseClasses;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace QA_WORKS_ASSESSMENT.Support.PageObjects
{
    class QAWorks_HomePage_PageObject : CorePagesOnMainRibon
    {
        public QAWorks_HomePage_PageObject()
        {
            PageTitle = "Home Page - QAWorks";
            PageUrl = "";
            Url = BaseUrl + PageUrl;
        }

        public void NavigateToHomePage()
        {
            Driver.CurrentDriver.Navigate().GoToUrl(Url);
        }
    }
}
