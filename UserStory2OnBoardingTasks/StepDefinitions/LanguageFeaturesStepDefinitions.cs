using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using UserStory2OnBoardingTasks.Pages;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.StepDefinitions
{
    [Binding]
    public class LanguageFeaturesStepDefinitions
    {
        private IWebDriver driver;
        Login loginPageObj;
        ProfileHomePage profileHomePageObj;
        LanguagesTabPage languageTabObj;

        public LanguageFeaturesStepDefinitions(IWebDriver driver) 
        { 
            this.driver = driver;
        }
        
        [Given(@"I logged in to ProjectMars successfully")]
        public void GivenILoggedInToProjectMarsSuccessfully()
        {
            loginPageObj = new Login(driver);
            Thread.Sleep(3000);
            loginPageObj.LoginFunction("srireka87@gmail.com","Rosesri@23");
            loginPageObj.LoginAssertion();
        }

        [Given(@"I navigate to Profile Language Page")]
        public void GivenINavigateToProfileLanguagePage()
        {
            profileHomePageObj = new ProfileHomePage(driver);
            profileHomePageObj.GotoProfileLangauge();
        }

        [When(@"I '([^']*)' and '([^']*)'")]
        public void WhenIAnd(string language, string level)
        {
            languageTabObj = new LanguagesTabPage(driver);
            languageTabObj.AddNewLanguage(language, level);

        }

        [Then(@"the'([^']*)'and '([^']*)' details should be created successfully")]
        public void ThenTheandDetailsShouldBeCreatedSuccessfully(string language, string level)
        {
            string actualNewLanguage = languageTabObj.GetActualLanguageAssertion();
            Assert.That(actualNewLanguage == language, "language is not matching");

            string actualNewLanguageLevel = languageTabObj.GetActualLanguageLevelAssertion();
            Assert.That(actualNewLanguageLevel == level, "Language Level is not matching");

        }

        [When(@"I Update '([^']*)' and '([^']*)' on existing records")]
        public void WhenIUpdateAndOnExistingRecords(string updateLanguage, string updateLangugeLevel)
        {

            languageTabObj.UpdateLanguages(driver, updateLanguage, updateLangugeLevel);

        }

        [Then(@"the record should be updated in '([^']*)'and '([^']*)' successfully")]
        public void ThenTheRecordShouldBeUpdatedInAndSuccessfully(string updateLanguage, string updateLanguageLevel)
        {

            string actualUpdatedLanguage = languageTabObj.ActualUpdateLanguageAssertion(driver);
            Assert.That(actualUpdatedLanguage == updateLanguage, "Updated Language is Unsuccessful");

            string actualUpdatedLanguageLevel = languageTabObj.ActualUpdateLanguageLevelAssertion(driver);
            Assert.That(actualUpdatedLanguageLevel == updateLanguageLevel, "Updated Language Level is Unsuccessful");


        }

        [When(@"I Add/Update '([^']*)' and '([^']*)' on existing records")]
        public void WhenIAddUpdateAndOnExistingRecords(string sameLanguage, string sameLanguageLevel)
        {
            languageTabObj.UpdateLanguages(driver, sameLanguage, sameLanguageLevel);

        }

        [Then(@"pop up message display as '([^']*)'")]
        public void ThenPopUpMessageDisplayAs(string p0)
        {

            string actualPopUpMessage = languageTabObj.SameLanguageAssertion(driver);
            Assert.That(actualPopUpMessage == p0, "Language is added");

        }

        [When(@"I click Delete Button for the '([^']*)'")]
        public void WhenIClickDeleteButtonForThe(string language)
        {

            languageTabObj.DeleteLanguage(driver);
        }

        [Then(@"the records should be deleted and message display as '([^']*)'")]
        public void ThenTheRecordsShouldBeDeletedAndMessageDisplayAs(string p0)
        {
            string actualPopUpMessage = languageTabObj.DeleteAssertion(driver);
            Assert.That(actualPopUpMessage == p0, "Deleting Language is unsuccessful");

        }

    }
}
