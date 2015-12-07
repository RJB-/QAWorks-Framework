using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using QA_WORKS_ASSESSMENT.Support.PageObjects;
using QA_WORKS_ASSESSMENT.Support.HelperObjects;
using TechTalk.SpecFlow.Assist;

namespace QA_WORKS_ASSESSMENT.FeatureSteps
{
    [Binding]
    public class QA_Works_Contact_Us_PageSteps
    {
        [Given(@"I am on the QAWorks Staging Site")]
        public void GivenIAmOnTheQAWorksStagingSite()
        {
            QAWorks_HomePage_PageObject qa_works_home_page = new QAWorks_HomePage_PageObject();
            qa_works_home_page.NavigateToHomePage();
        }


        [When(@"I navigate to the Contact Us page")]
        public void WhenINavigateToTheContactUsPage()
        {
            QAWorks_HomePage_PageObject qa_works_home_page = new QAWorks_HomePage_PageObject();
            qa_works_home_page.WaitForPageToLoad(qa_works_home_page.PageTitle);
            qa_works_home_page.ClickLink(qa_works_home_page.contact_link);
        }


        [When(@"I attempt to send a message to QAWorks with an incorrect Email Address format")]
        [Then(@"I should be able to contact QAWorks with the following information")]
        public void ThenIShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            ContactUsDataTable data = table.CreateInstance<ContactUsDataTable>();

            QAWorks_ContactUs_PageObject qa_works_contact_page = new QAWorks_ContactUs_PageObject();
            qa_works_contact_page.WaitForPageToLoad(qa_works_contact_page.PageTitle);
            qa_works_contact_page.EnterName(data.name);
            qa_works_contact_page.EnterEmailAddress(data.email);
            qa_works_contact_page.EnterMessage(data.message);
            qa_works_contact_page.ClickSend();
        }


        [When(@"I click send")]
        public void WhenIClickSend()
        {
            QAWorks_ContactUs_PageObject qa_works_contact_page = new QAWorks_ContactUs_PageObject();
            qa_works_contact_page.WaitForPageToLoad(qa_works_contact_page.PageTitle);
            qa_works_contact_page.ClickSend();
        }


        [Then(@"I should see a error that says a name is required")]
        public void ThenIShouldSeeAErrorThatSaysANameIsRequired()
        {
            QAWorks_ContactUs_PageObject qa_works_contact_page = new QAWorks_ContactUs_PageObject();
            Assert.IsTrue(Driver.CurrentDriver.FindElement(qa_works_contact_page.getNameRequired()).Displayed);
        }


        [Then(@"I should see an error that says a message is required")]
        public void ThenIShouldSeeAnErrorThatSaysAMessageIsRequired()
        {
            QAWorks_ContactUs_PageObject qa_works_contact_page = new QAWorks_ContactUs_PageObject();
            Assert.IsTrue(Driver.CurrentDriver.FindElement(qa_works_contact_page.getMessageRequired()).Displayed);
        }


        [Then(@"I should see an eror that says an email is required")]
        public void ThenIShouldSeeAnErorThatSaysAnEmailIsRequired()
        {
            QAWorks_ContactUs_PageObject qa_works_contact_page = new QAWorks_ContactUs_PageObject();
            Assert.IsTrue(Driver.CurrentDriver.FindElement(qa_works_contact_page.getEmailRequired()).Displayed);
        }


        [When(@"I should see an eror that says an email is required")]
        public void WhenIShouldSeeAnErorThatSaysAnEmailIsRequired()
        {
            QAWorks_ContactUs_PageObject qa_works_contact_page = new QAWorks_ContactUs_PageObject();
            Assert.IsTrue(Driver.CurrentDriver.FindElement(qa_works_contact_page.getEmailIncorrectFormat()).Displayed);
        }
    }
}
