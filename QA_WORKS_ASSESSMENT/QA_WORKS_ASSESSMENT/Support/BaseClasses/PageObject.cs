using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using QA_WORKS_ASSESSMENT.Support.HelperObjects;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Diagnostics;
using System;

namespace QA_WORKS_ASSESSMENT.Support.BaseClasses
{
    // Base Page Object class - contains variables and Methods common to ALL Page Objects
    abstract class PageObject
    {
        //Get homepage URL from App.config
        protected string BaseUrl = ConfigurationSettings.AppSettings["HomePage"];

        //Variables
        internal string Url { get; set; }
        internal string PageUrl { get; set; }
        internal string PageTitle { get; set; }

        //Wait for the page to load
        public void WaitForPageToLoad(string PageTitle)
        {
            var wait = Driver.Wait();

            try
            {
                wait.Until(p => p.Title == PageTitle);
            }
            catch (Exception e)
            {
                string scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
                Console.WriteLine("Failed: " + scenarioName + ": " + e.Message);
                throw;
            }
        }
    }
}
