using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using UserStory2OnBoardingTasks.Pages;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.StepDefinitions
{
    [Binding]
    public class SkillsFeaturesStepDefinitions :CommonDriver
    {
        Login loginPageObj;
        SkillsTabPage skillsTabPageObj;
        ProfileHomePage profileHomePageObj;

        public SkillsFeaturesStepDefinitions()
        {
            profileHomePageObj = new ProfileHomePage();
            skillsTabPageObj = new SkillsTabPage();
            loginPageObj = new Login();
        }


        [Given(@"I logged in to ProjectMars successfully")]
        public void GivenILoggedInToProjectMarsSuccessfully()
        {
            Thread.Sleep(2000);
            loginPageObj.LoginFunction("srireka87@gmail.com", "Rosesri@23");
            loginPageObj.LoginAssertion();
        }

        [Given(@"I navigate to Profile Skills Page")]
        public void GivenINavigateToProfileSkillsPage()
        {
           
            profileHomePageObj.GoToProfileSkills();
        }

        [When(@"I '([^']*)'and '([^']*)'")]
        public void WhenIAnd(string skill, string level)
        {
            
            skillsTabPageObj.AddNewSkill(skill, level);
        }

        [Then(@"The'([^']*)'and '([^']*)' details should be created successfully")]
        public void ThenTheandDetailsShouldBeCreatedSuccessfully(string skill, string level)
        {
            string actualNewSkill = skillsTabPageObj.GetActualSkillAssertion();
            Assert.That(actualNewSkill == skill,"Skill is not matching");

            string actualNewSkillLevel = skillsTabPageObj.GetActualSkillLevelAssertion();
            Assert.That(actualNewSkillLevel == level,"Skill Level is not matching");
        }

        [When(@"Updating '([^']*)' and '([^']*)'")]
        public void WhenUpdatingAnd(string updateSkill, string updateSkillLevel)
        {
            skillsTabPageObj.UpdateSkill(updateSkill, updateSkillLevel);
        }

        [Then(@"skills should be updated in '([^']*)'and '([^']*)' successfully")]
        public void ThenSkillsShouldBeUpdatedInAndSuccessfully(string updateSkill, string updateSkillLevel)
        {
            string actualUpdatedSkill = skillsTabPageObj.ActualUpdateSkillAssertion();
            Console.WriteLine(actualUpdatedSkill);
            Assert.That(actualUpdatedSkill == updateSkill, "Updated Skill is Unsuccessful");

            string actualUpdatedSkillLevel = skillsTabPageObj.ActualUpdateSkillLevelAssertion();
            Assert.That(actualUpdatedSkillLevel == updateSkillLevel, "Updated Skill Level is Unsuccessful");
        }
        [Given(@"adding '([^']*)' and '([^']*)'")]
        public void GivenAddingAnd(string skill, string level)
        {
            
            skillsTabPageObj.AddNewSkill(skill, level);
        }

        [When(@"I Adding /Updating existing '([^']*)' and '([^']*)' on existing records")]
        public void WhenIAddingUpdatingExistingAndOnExistingRecords(string skill, string level)
        {
               
            skillsTabPageObj.UpdateSkill(skill,level);
        }

        [Then(@"Popup message display as '([^']*)'")]
        public void ThenPopupMessageDisplayAs(string p0)
        {
            string actualPopUpMessage = skillsTabPageObj.ExistingSkillLevelAssertion();
            Console.WriteLine(actualPopUpMessage);
            Assert.That(actualPopUpMessage == p0, "Existing skill is unsuccessful");
            
        }

        [Given(@"I Add '([^']*)' and '([^']*)'")]
        public void GivenIAddAnd(string skill, string level)
        {
           
            skillsTabPageObj.AddNewSkill(skill, level);
        }

        [When(@"I Delete for the '([^']*)'")]
        public void WhenIDeleteForThe(string skill)
        {
           
           skillsTabPageObj.DeleteSkills();
        }

        [Then(@"the record should be deleted and message display as '([^']*)'")]
        public void ThenTheRecordShouldBeDeletedAndMessageDisplayAs(string p0)
        {
            string actualPopUpMessage = skillsTabPageObj.DeleteSkillsAssertion();
            Assert.That(actualPopUpMessage == p0, "Deleting Skill is unsuccessful");
        }

        [Given(@"I adding '([^']*)' and '([^']*)'")]
        public void GivenIAddingAnd(string skill, string level)
        {
            
            skillsTabPageObj.CancelSkills(skill, level);
        }

        [Then(@"Click Cancel Button")]
        public void ThenClickCancelButton()
        {
            skillsTabPageObj.CancelFunction();
        }

        [Then(@"the'([^']*)'and '([^']*)' details should be cancelled\.")]
        public void ThenTheandDetailsShouldBeCancelled_(string skill, string level)
        {
            skillsTabPageObj.CancelAssertion();
        }

        [When(@"I enter only '([^']*)' OR '([^']*)'")]
        public void WhenIEnterOnlyOR(string skill, string level)
        {
           
            skillsTabPageObj.EnterOnlySkillORLevel(skill, level);
        }

        [Then(@"notification show as '([^']*)'")]
        public void ThenNotificationShowAs(string p0)
        {
            string actualNotificationMessage = skillsTabPageObj.EnterOnlySkillLevelAssertion();
            Console.WriteLine(actualNotificationMessage);
            Console.WriteLine(p0);
            Assert.That(actualNotificationMessage == p0, "Unsuccessful");
        }


    }
}
