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
       //Adding New Skill
        private IWebElement AddNewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement AddSkillTextBox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private IWebElement AddSkillLevelDropDown => driver.FindElement(By.TagName("select"));
        private IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement ActualSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement ActualSkillLevel =>driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        //Update Skill
       private IWebElement UpdateIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement UpdateSkillTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private IWebElement UpdateSkillLevelDropDown => driver.FindElement(By.TagName("select"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));                                   
        private IWebElement ActualUpdatedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement ActualUpdatedSkillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
       
        //Add &Updating the same Language PopUpMsg
        private IWebElement ActualPopUpMsg => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        private IWebElement DeleteIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[last()]/span[2]/i"));
        private IWebElement ActualPopUpDeleteMsg => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        private IWebElement CancelButton => driver.FindElement(By.XPath("//input[@value='Cancel']"));
        private IWebElement SkillsTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));

        private IWebElement NotificationForOnlyEnteringSkill => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement SkillsTable => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
        private IList<IWebElement> SkillsTableRows => SkillsTable.FindElements(By.TagName("tr"));
       // private IList<IWebElement> SkillsTableRows => SkillsTable.FindElements(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr"));

        public void AddNewSkill(string skill, string level)
        {
            if (SkillsTableRows.Count > 0)
            {

                Thread.Sleep(2000);
                try
                {
                    for (int i = 1; i < SkillsTableRows.Count; i++)
                    {
                        IWebElement row = SkillsTableRows[i];
                        IWebElement DeleteButton = row.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                        DeleteButton.Click();
                    }
                }
                catch (StaleElementReferenceException) { }
            }

            Thread.Sleep(3000);
            AddNewButton.Click();
            AddSkillTextBox.SendKeys(skill);
            AddSkillLevelDropDown.SendKeys(level);
            AddButton.Click();
        }
        public string GetActualSkillAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]",7);
            string actualSkill1 = ActualSkill.Text;
            Console.WriteLine(actualSkill1);
            return actualSkill1;
        }
        public string GetActualSkillLevelAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]",7);
            string actualSkillLevel1 =ActualSkillLevel.Text;
            Console.WriteLine(actualSkillLevel1 );
            return actualSkillLevel1;
        }
        public void UpdateSkill(string updateSkill, string updateSkillLevel)
        {

            Thread.Sleep(5000);
            UpdateIcon.Click();
            UpdateSkillTextBox.Clear();
            UpdateSkillTextBox.SendKeys(updateSkill);
            UpdateSkillLevelDropDown.Click();
            UpdateSkillLevelDropDown.SendKeys(updateSkillLevel);
            UpdateButton.Click();
        }
        public string ActualUpdateSkillAssertion()
        {
            Thread.Sleep(2000);                                               
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 50);
            string actualUpdatedSkill1 = ActualUpdatedSkill.Text;
            return actualUpdatedSkill1;
        }
        public string ActualUpdateSkillLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]",50);
            string actualUpdatedSkillLevel1 = ActualUpdatedSkillLevel.Text;
            return actualUpdatedSkillLevel1;
        }
        public string ExistingSkillLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 40);
            string actualPopUpMsg1 = ActualPopUpMsg.Text;
            return actualPopUpMsg1;
        }
        public void DeleteSkills()
        {
            Thread.Sleep(4000);
            DeleteIcon.Click();
        }
        public string DeleteSkillsAssertion()
        {
            Thread.Sleep(4000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",70);
            string actualPopUpDeleteMsg1 = ActualPopUpMsg.Text;
            return actualPopUpDeleteMsg1;
        }
        public void CancelSkills(string language, string level)
        {
            AddNewButton.Click();
            AddSkillTextBox.SendKeys(language);
            AddSkillLevelDropDown.SendKeys(level);
        }
        public void CancelFunction()
        {
            CancelButton.Click();
        }
        public void CancelAssertion()
        {
            SkillsTab.Click();
        }
        public void EnterOnlySkillORLevel(string skill, string level)
        {
            AddNewButton.Click();
            AddSkillTextBox.SendKeys(skill);
            AddSkillLevelDropDown.SendKeys(level);
            AddButton.Click();
        }
        public string EnterOnlySkillLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 50);
            string notificationForOnlyEnteringSkill1 = NotificationForOnlyEnteringSkill.Text;
            return notificationForOnlyEnteringSkill1;
        }


    }
}
