using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.Pages
{
    public class LanguagesTabPage :CommonDriver
    {
        
        public LanguagesTabPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //Adding New Language
        By addNewButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        By addLanguageTextBox = By.XPath("//input[@placeholder='Add Language']");
        By addLanguageLevelDropDown = By.TagName("select");
        By addButton = By.XPath("//input[@value='Add']");
        By actualLanguage = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By actualLanguageLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");

        //Update Language
        By updateIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        By updateLanguageTextBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input");
        By updateLanguageLevelDropDown = By.TagName("select");
        By updateButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
        By actualUpdatedLanguage = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By actualUpdatedLanguageLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");
        
        //Add &Updating the same Language PopUpMsg
        By actualPopUpMsg = By.XPath("//div[@class='ns-box-inner']");

        //Deleting icon
        By deleteIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[last()]/span[2]/i");
        By actualPopUpDeleteMsg = By.XPath("//div[@class='ns-box-inner']");
        
        By cancelButton = By.XPath("//input[@value='Cancel']");
        By languageTab = By.XPath("//a[contains(text(),'Languages')]");

        By notificationForOnlyEnteringLanguage = By.XPath("//div[@class='ns-box-inner']");


        public void AddNewLanguage(string language, string level)
        {
            driver.FindElement(addNewButton).Click();
            driver.FindElement(addLanguageTextBox).SendKeys(language);
            driver.FindElement(addLanguageLevelDropDown).SendKeys(level);
            driver.FindElement(addButton).Click();
        }
        public string GetActualLanguageAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",7);
            string actualLanguage1 =driver.FindElement(actualLanguage).Text;
            return actualLanguage1;
        }
        public string GetActualLanguageLevelAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]",7);
            string actualLanguageLevel1 = driver.FindElement(actualLanguageLevel).Text;
            return actualLanguageLevel1;
        }
        public void UpdateLanguages(string updateLanguage, string updateLevel)
        {
           
            Thread.Sleep(5000);
            driver.FindElement(updateIcon).Click();
            driver.FindElement(updateLanguageTextBox).Clear();
            driver.FindElement(updateLanguageTextBox).SendKeys(updateLanguage);
            driver.FindElement(updateLanguageLevelDropDown).Click();
            driver.FindElement(updateLanguageLevelDropDown).SendKeys(updateLevel);
            driver.FindElement(updateButton).Click();
        }
        public string ActualUpdateLanguageAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",70);
            string actualUpdatedLanguage1 = driver.FindElement(actualUpdatedLanguage).Text;
            return actualUpdatedLanguage1;
        }
        public string ActualUpdateLanguageLevelAssertion()
        {
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]",70);
            string actualUpdatedLanguageLevel1= driver.FindElement(actualUpdatedLanguageLevel).Text;
            return actualUpdatedLanguageLevel1;
        }
        public string SameLanguageAssertion()
        {
            
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",40);
            string actualPopUpMsg1 =driver.FindElement(actualPopUpMsg).Text;
            return actualPopUpMsg1;
        }
        public void DeleteLanguage()
        {

            Thread.Sleep(4000);
            driver.FindElement(deleteIcon).Click();
        }
        public string DeleteAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",50);
            string actualPopUpDeleteMsg1= driver.FindElement(actualPopUpMsg).Text;
            return actualPopUpDeleteMsg1;
        }
        public void CancelLanguage(string language,string level)
        {
            driver.FindElement(addNewButton).Click();
            driver.FindElement(addLanguageTextBox).SendKeys(language);
            driver.FindElement(addLanguageLevelDropDown).SendKeys(level);
        }
        public void CancelFunction()
        {
            driver.FindElement(cancelButton).Click();
        }

        public void CancelAssertion()
        {
            driver.FindElement(languageTab).Click();
        }
        public void EnterOnlyLnaguageORLevel( string language,string level)
        {
            driver.FindElement(addNewButton).Click();
            driver.FindElement(addLanguageTextBox).SendKeys(language);
            driver.FindElement(addLanguageLevelDropDown).SendKeys(level);
            driver.FindElement(addButton).Click();
        }
        public string EnterOnlyLanguageLevelAssertion()
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 50);
            string notificationForOnlyEnteringLanguage1 = driver.FindElement(notificationForOnlyEnteringLanguage).Text;
            return notificationForOnlyEnteringLanguage1;
        }

    }
}


