using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;

namespace QA_WORKS_ASSESSMENT.Support.HelperObjects
{
    class WebBrowserSetup
    {
        public void StartWebBrowser()
        {
            FirefoxBinary ffBinary = new FirefoxBinary(ConfigurationSettings.AppSettings["ffBinary"]);

            // Create a FireFox profile and add the FireBug and FirePath to the browser object
            FirefoxProfile ffProfile = new FirefoxProfile();

            // FireFox Addins are not working when using SpecRun
            //ffProfile.AddExtension(ConfigurationSettings.AppSettings["firebug"]);
            //ffProfile.AddExtension(ConfigurationSettings.AppSettings["firepath"]);

            // Create FireFox Driver object using the profile above
            Driver.CurrentDriver = new FirefoxDriver(ffBinary, ffProfile);
            Driver.CurrentDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Driver.CurrentDriver.Manage().Window.Maximize();
        }
    }
}
