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
    public class LanguageFeaturesStepDefinitions:CommonDriver
    {
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
            profileHomePageObj.GoToProfileLangauges();
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
            languageTabObj =new LanguagesTabPage(driver);
            languageTabObj.UpdateLanguages(updateLanguage, updateLangugeLevel);

        }

        [Then(@"the record should be updated in '([^']*)'and '([^']*)' successfully")]
        public void ThenTheRecordShouldBeUpdatedInAndSuccessfully(string updateLanguage, string updateLanguageLevel)
        {
            string actualUpdatedLanguage = languageTabObj.ActualUpdateLanguageAssertion();
            Assert.That(actualUpdatedLanguage == updateLanguage, "Updated Language is Unsuccessful");

            string actualUpdatedLanguageLevel = languageTabObj.ActualUpdateLanguageLevelAssertion();
            Assert.That(actualUpdatedLanguageLevel == updateLanguageLevel, "Updated Language Level is Unsuccessful");
        }

        [When(@"I Updating '([^']*)' and '([^']*)' on existing records")]
        public void WhenIUpdatingAndOnExistingRecords(string sameLanguage, string sameLanguageLevel)
        {
            languageTabObj = new LanguagesTabPage(driver);
            languageTabObj.UpdateLanguages(sameLanguage, sameLanguageLevel);
        }
          
        [Then(@"pop up message display as '([^']*)'")]
        public void ThenPopUpMessageDisplayAs(string p0)
        {
            string actualPopUpMessage = languageTabObj.SameLanguageAssertion();
            Assert.That(actualPopUpMessage == p0, "Language is added");
        }

        [Given(@"Adding '([^']*)' and '([^']*)'")]
        public void GivenAddingAnd(string language,string level)
        {
            languageTabObj = new LanguagesTabPage(driver);
            languageTabObj.AddNewLanguage(language,level);

        }

        [When(@"I click Delete Button for the '([^']*)'")]
        public void WhenIClickDeleteButtonForThe(string language)
        {
            languageTabObj = new LanguagesTabPage(driver);
            languageTabObj.DeleteLanguage();
        }

        [Then(@"the records should be deleted and message display as '([^']*)'")]
        public void ThenTheRecordsShouldBeDeletedAndMessageDisplayAs(string p0)
        {
            string actualPopUpMessage = languageTabObj.DeleteAssertion();
            Assert.That(actualPopUpMessage == p0, "Deleting Language is unsuccessful");

        }
        [When(@"I adding'([^']*)' and '([^']*)'")]
        public void WhenIAddingAnd(string language, string level)
        {
            languageTabObj = new LanguagesTabPage(driver);
            languageTabObj.CancelLanguage(language, level);
        }

        [When(@"Click Cancel Button")]
        public void WhenClickCancelButton()
        {
            languageTabObj.CancelFunction();
        }

        [Then(@"the'([^']*)'and '([^']*)' details should be cancelled successfully")]
        public void ThenTheandDetailsShouldBeCancelledSuccessfully(string language, string level)
        {
            languageTabObj.CancelAssertion();
        }

        [When(@"I  enter only '([^']*)' OR '([^']*)'")]
        public void WhenIEnterOnlyOR(string language, string level)
        {
            languageTabObj = new LanguagesTabPage(driver);
            languageTabObj.EnterOnlyLnaguageORLevel(language,level);

        }

        [Then(@"notification display as '([^']*)'")]
        public void ThenNotificationDisplayAs(string p0)
        {
            string actualNotificationMessage = languageTabObj.EnterOnlyLanguageLevelAssertion();
            Console.WriteLine(actualNotificationMessage);
            Console.WriteLine(p0);
            Assert.That(actualNotificationMessage == p0, "Unsuccessful");
        }









    }
}
