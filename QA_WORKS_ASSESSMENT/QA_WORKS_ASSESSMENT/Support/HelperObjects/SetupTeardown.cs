using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace QA_WORKS_ASSESSMENT.Support.HelperObjects
{
    [Binding]
    public class SetupTeardown
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }


        [BeforeScenario]
        public static void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            
            WebBrowserSetup webBrowserSetup = new WebBrowserSetup();
            webBrowserSetup.StartWebBrowser();
        }


        [AfterScenario]
        public static void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Driver.CurrentDriver.Quit();
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {

        }
    }
}
