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
using System.Diagnostics;
using System.Drawing.Imaging;

namespace QA_WORKS_ASSESSMENT.Support.HelperObjects
{
    class Utilities
    {
        public void CloseAllBrowsers()
        {
            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "firefox" || s == "iexplore" || s == "chrome")
                        process.Kill();
                }
            }
        }

        public static void takeScreenshot(string strImageFilePathAndName)
        {

            var screenShot = ((ITakesScreenshot)Driver.CurrentDriver).GetScreenshot();
            screenShot.SaveAsFile(strImageFilePathAndName, ImageFormat.Png);
        }
    }
}
