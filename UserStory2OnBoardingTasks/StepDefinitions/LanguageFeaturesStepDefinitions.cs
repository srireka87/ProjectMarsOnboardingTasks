using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using UserStory2OnBoardingTasks.Pages;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.StepDefinitions
{
    [Binding]
    public class LanguageFeaturesStepDefinitions:CommonDriver
    {

        
        Login loginPageObj = new Login();
        ProfileHomePage profileHomePageObj = new ProfileHomePage();
        LanguagesTabPage languageTabObj = new LanguagesTabPage();

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
            profileHomePageObj.GotoProfileLangauge(driver);
        }

        [When(@"I '([^']*)' and '([^']*)'")]
        public void WhenIAnd(string language, string level)
        {
            languageTabObj.AddNewLanguage(driver,language,level);
            
        }

        [Then(@"the'([^']*)'and '([^']*)' details should be created successfully")]
        public void ThenTheandDetailsShouldBeCreatedSuccessfully(string language, string level)
        {
            string actualNewLanguage = languageTabObj.GetActualLanguageAssertion(driver);
            Assert.That(actualNewLanguage == language, "language is not matching");

            string actualNewLanguageLevel = languageTabObj.GetActualLanguageLevelAssertion(driver);
            Assert.That(actualNewLanguageLevel == level, "Language Level is not matching");
        }

        [When(@"I Update '([^']*)' and '([^']*)' on existing records")]
        public void WhenIUpdateAndOnExistingRecords(string updateLanguage, string updateLangugeLevel)
        {
            
            languageTabObj.UpdateLanguages(driver, updateLanguage, updateLangugeLevel);

        }
        [Then(@"The'([^']*)'and '([^']*)' details should be updated successfully")]
        public void ThenTheandDetailsShouldBeUpdatedSuccessfully(string updateLanguage, string updateLanguageLevel)
        {
            string actualUpdatedLanguage = languageTabObj.ActualUpdateLanguageAssertion(driver);
            Assert.That(actualUpdatedLanguage == updateLanguage, "Updated Language is Unsuccessful");

            string actualUpdatedLanguageLevel = languageTabObj.ActualUpdateLanguageLevelAssertion(driver);
            Assert.That(actualUpdatedLanguageLevel == updateLanguageLevel, "Updated Language Level is Unsuccessful");

        }

    }
}
