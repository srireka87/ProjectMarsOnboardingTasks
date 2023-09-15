using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using UserStory2OnBoardingTasks.Pages;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.StepDefinitions
{
    [Binding]
    public class LanguageFeaturesStepDefinitions:CommonDriver
    {
        Login loginPageObj = new Login();

        [Given(@"I logged in to ProjectMars successfully")]
        public void GivenILoggedInToProjectMarsSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginFunction(driver);
            loginPageObj.LoginAssertion(driver);
        }

        [Given(@"I navigate to Profile Language Page")]
        public void GivenINavigateToProfileLanguagePage()
        {
            throw new PendingStepException();
        }

        [When(@"I Add a NewLanguage and Language Level")]
        public void WhenIAddANewLanguageAndLanguageLevel()
        {
            throw new PendingStepException();
        }

        [Then(@"the Language details should be created successfully")]
        public void ThenTheLanguageDetailsShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
