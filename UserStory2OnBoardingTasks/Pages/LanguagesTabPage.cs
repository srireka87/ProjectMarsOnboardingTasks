using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.Pages
{
    public class LanguagesTabPage:CommonDriver

    {
        public LanguagesTabPage(IWebDriver driver) : base(driver)
        {
            // The base constructor initializes the 'driver' field
        }


        //Adding New Language
        private IWebElement AddNewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement AddLanguageTextBox => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private IWebElement AddLanguageLevelDropDown => driver.FindElement(By.TagName("select"));
        private IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement ActualLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement ActualLanguageLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        //Update Language
        private IWebElement UpdateIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement UpdateLanguageTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private IWebElement UpdateLanguageLevelDropDown => driver.FindElement(By.TagName("select"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        private IWebElement ActualUpdatedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement ActualUpdatedLanguageLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        //Add &Updating the same Language PopUpMsg
        private IWebElement ActualPopUpMsg => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        //Deleting icon
        private IWebElement DeleteIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[last()]/span[2]/i"));
        private IWebElement ActualPopUpDeleteMsg => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        
        private IWebElement CancelButton => driver.FindElement(By.XPath("//input[@value='Cancel']"));
        private IWebElement LanguageTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));

        private IWebElement NotificationForOnlyEnteringLanguage => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

 
        public void AddNewLanguage(string language, string level)
        {
            AddNewButton.Click();
            AddLanguageTextBox.SendKeys(language);
            AddLanguageLevelDropDown.SendKeys(level);
            AddButton.Click();
        }
        public string GetActualLanguageAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",7);
            string actualLanguage1 =ActualLanguage.Text;
            return actualLanguage1;
        }
        public string GetActualLanguageLevelAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]",7);
            string actualLanguageLevel1 = ActualLanguageLevel.Text;
            return actualLanguageLevel1;
        }
        public void UpdateLanguages(string updateLanguage, string updateLevel)
        {
           
            Thread.Sleep(5000);
            UpdateIcon.Click();
            UpdateLanguageTextBox.Clear();
            UpdateLanguageTextBox.SendKeys(updateLanguage);
            UpdateLanguageLevelDropDown.Click();
            UpdateLanguageLevelDropDown.SendKeys(updateLevel);
            UpdateButton.Click();
        }
        public string ActualUpdateLanguageAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",70);
            string actualUpdatedLanguage1 = ActualUpdatedLanguage.Text;
            return actualUpdatedLanguage1;
        }
        public string ActualUpdateLanguageLevelAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]",70);
            string actualUpdatedLanguageLevel1= ActualUpdatedLanguageLevel.Text;
            return actualUpdatedLanguageLevel1;
        }
        public string SameLanguageAssertion()
        {
            
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",40);
            string actualPopUpMsg1 =ActualPopUpMsg.Text;
            return actualPopUpMsg1;
        }
        public void DeleteLanguage()
        {

            Thread.Sleep(4000);
            DeleteIcon.Click();
        }
        public string DeleteAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",50);
            string actualPopUpDeleteMsg1= ActualPopUpMsg.Text;
            return actualPopUpDeleteMsg1;
        }
        public void CancelLanguage(string language,string level)
        {
           AddNewButton.Click();
           AddLanguageTextBox.SendKeys(language);
           AddLanguageLevelDropDown.SendKeys(level);
        }
        public void CancelFunction()
        {
            CancelButton.Click();
        }

        public void CancelAssertion()
        {
           LanguageTab.Click();
        }
        public void EnterOnlyLnaguageORLevel( string language,string level)
        {
            AddNewButton.Click();
            AddLanguageTextBox.SendKeys(language);
            AddLanguageLevelDropDown.SendKeys(level);
            AddButton.Click();
        }
        public string EnterOnlyLanguageLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 50);
            string notificationForOnlyEnteringLanguage1 = NotificationForOnlyEnteringLanguage.Text;
            return notificationForOnlyEnteringLanguage1;
        }
        
    }
}


