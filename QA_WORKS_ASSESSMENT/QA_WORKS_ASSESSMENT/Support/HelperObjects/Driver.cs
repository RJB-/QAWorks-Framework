using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace QA_WORKS_ASSESSMENT.Support.HelperObjects
{
    class Driver
    {
        public static IWebDriver CurrentDriver { get; set; }

        internal static string Title
        {
            get { return CurrentDriver.Title; }
        }

        internal static WebDriverWait Wait()
        {
            return new WebDriverWait(CurrentDriver, TimeSpan.FromSeconds(30));
        }

        public static void Quit()
        {
            CurrentDriver.Quit();
        }

    }
}
