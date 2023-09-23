using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.Pages
{
    public class SkillsTabPage:CommonDriver
    {

        public SkillsTabPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //Adding New Skill
        By addNewButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        By addSkillTextBox = By.XPath("//input[@placeholder='Add Skill']");
        By addSkillLevelDropDown = By.TagName("select");
        By addButton = By.XPath("//input[@value='Add']");
        By actualSkill = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By actualSkillLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]");

        //Update Skill
        By updateIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        By updateSkillTextBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input");
        By updateSkillLevelDropDown = By.TagName("select");
        By updateButton = By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");                                   
        By actualUpdatedSkill = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By actualUpdatedSkillLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]");
       
        //Add &Updating the same Language PopUpMsg
        By actualPopUpMsg = By.XPath("//div[@class='ns-box-inner']");

        By deleteIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[last()]/span[2]/i");
        By actualPopUpDeleteMsg = By.XPath("//div[@class='ns-box-inner']");

        By cancelButton = By.XPath("//input[@value='Cancel']");
        By skillsTab = By.XPath("//a[contains(text(),'Skills')]");

        By notificationForOnlyEnteringSkill = By.XPath("//div[@class='ns-box-inner']");

        public void AddNewSkill(string skill, string level)
        { 
            driver.FindElement(addNewButton).Click();
            driver.FindElement(addSkillTextBox).SendKeys(skill);
            driver.FindElement(addSkillLevelDropDown).SendKeys(level);
            driver.FindElement(addButton).Click();
        }
        public string GetActualSkillAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]",7);
            string actualSkill1 = driver.FindElement(actualSkill).Text;
            Console.WriteLine(actualSkill1);
            return actualSkill1;
        }
        public string GetActualSkillLevelAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]",7);
            string actualSkillLevel1 = driver.FindElement(actualSkillLevel).Text;
            Console.WriteLine(actualSkillLevel1 );
            return actualSkillLevel1;
        }
        public void UpdateSkill(string updateSkill, string updateSkillLevel)
        {

            Thread.Sleep(5000);
            driver.FindElement(updateIcon).Click();
            driver.FindElement(updateSkillTextBox).Clear();
            driver.FindElement(updateSkillTextBox).SendKeys(updateSkill);
            driver.FindElement(updateSkillLevelDropDown).Click();
            driver.FindElement(updateSkillLevelDropDown).SendKeys(updateSkillLevel);
            driver.FindElement(updateButton).Click();
        }
        public string ActualUpdateSkillAssertion()
        {
            Thread.Sleep(2000);                                               
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 50);
            string actualUpdatedSkill1 = driver.FindElement(actualUpdatedSkill).Text;
            return actualUpdatedSkill1;
        }
        public string ActualUpdateSkillLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]",50);
            string actualUpdatedSkillLevel1 = driver.FindElement(actualUpdatedSkillLevel).Text;
            return actualUpdatedSkillLevel1;
        }
        public string ExistingSkillLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 40);
            string actualPopUpMsg1 = driver.FindElement(actualPopUpMsg).Text;
            return actualPopUpMsg1;
        }
        public void DeleteSkills()
        {
            Thread.Sleep(4000);
            driver.FindElement(deleteIcon).Click();
        }
        public string DeleteSkillsAssertion()
        {
            Thread.Sleep(4000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",70);
            string actualPopUpDeleteMsg1 = driver.FindElement(actualPopUpMsg).Text;
            return actualPopUpDeleteMsg1;
        }
        public void CancelSkills(string language, string level)
        {
            driver.FindElement(addNewButton).Click();
            driver.FindElement(addSkillTextBox).SendKeys(language);
            driver.FindElement(addSkillLevelDropDown).SendKeys(level);
        }
        public void CancelFunction()
        {
            driver.FindElement(cancelButton).Click();
        }
        public void CancelAssertion()
        {
            driver.FindElement(skillsTab).Click();
        }
        public void EnterOnlySkillORLevel(string skill, string level)
        {
            driver.FindElement(addNewButton).Click();
            driver.FindElement(addSkillTextBox).SendKeys(skill);
            driver.FindElement(addSkillLevelDropDown).SendKeys(level);
            driver.FindElement(addButton).Click();
        }
        public string EnterOnlySkillLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 50);
            string notificationForOnlyEnteringSkill1 = driver.FindElement(notificationForOnlyEnteringSkill).Text;
            return notificationForOnlyEnteringSkill1;
        }


    }
}
