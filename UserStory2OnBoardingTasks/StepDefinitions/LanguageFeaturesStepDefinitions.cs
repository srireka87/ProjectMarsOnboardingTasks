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

            languageTabObj.CloseTheDriver(driver);
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

            languageTabObj.CloseTheDriver(driver);

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

            languageTabObj.CloseTheDriver(driver);
        }


        [When(@"I click Delete Button")]
        public void WhenIClickDeleteButton()
        {
            languageTabObj.DeleteLanguage(driver);
        }

        [Then(@"the records should be deleted")]
        public void ThenTheRecordsShouldBeDeleted()
        {
            String actualDeletedRecord=languageTabObj.DeleteAssertion(driver);
            Assert.That(actualDeletedRecord !="Spanish", "Delete is unsuccessful");
            languageTabObj.CloseTheDriver(driver);
        }



    }
}
