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
        By addLanguageTextBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
        By addLanguageLevelDropDown = By.TagName("select");
        By addButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        By actualLanguage = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By actualLanguageLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");

        //Update Language
        By updateIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        By updateLanguageTextBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input");
        By updateLanguageLevelDropDown = By.TagName("select");
        By updateButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
        By actualUpdatedLanguage = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By actualUpdatedLanguageLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");
        
        //Add /Updating the same Language PopUpMsg
        By actualPopUpMsg = By.XPath("//div[@class='ns-box-inner']");

        //Deleting icon
        By deleteIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[last()]/span[2]/i");
        By actualPopUpDeleteMsg = By.XPath("//div[@class='ns-box-inner']");

        public void AddNewLanguage(string language, string level)
        {

            driver.FindElement(addNewButton).Click();
            driver.FindElement(addLanguageTextBox).SendKeys(language);
            driver.FindElement(addLanguageLevelDropDown).SendKeys(level);
            driver.FindElement(addButton).Click();
        }
        public string GetActualLanguageAssertion()
        {
            Thread.Sleep(4000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",5);
            string actualLanguage1 =driver.FindElement(actualLanguage).Text;
            return actualLanguage1;
        }
        public string GetActualLanguageLevelAssertion()
        {
            Thread.Sleep(4000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]",5);
            string actualLanguageLevel1 = driver.FindElement(actualLanguageLevel).Text;
            return actualLanguageLevel1;
        }
        public void UpdateLanguages(string updateLanguage, string updateLevel)
        { 
            //Click Update icon       
             driver.FindElement(updateIcon).Click();

            //Update the Language
            driver.FindElement(updateLanguageTextBox).Clear();
            driver.FindElement(updateLanguageTextBox).SendKeys(updateLanguage);

            //update the  Language Level
            driver.FindElement(updateLanguageLevelDropDown).Click();
            driver.FindElement(updateLanguageLevelDropDown).SendKeys(updateLevel);

            //Click Update Button
            driver.FindElement(updateButton).Click();
        }
        public string ActualUpdateLanguageAssertion()
        {
            //Get the Updated New language  for validation
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",10);
            string actualUpdatedLanguage1 = driver.FindElement(actualUpdatedLanguage).Text;
            return actualUpdatedLanguage1;
        }
        public string ActualUpdateLanguageLevelAssertion()
        {
            //Get the upated New Language Level  for Validation
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]",20);
            string actualUpdatedLanguageLevel1= driver.FindElement(actualUpdatedLanguageLevel).Text;
            return actualUpdatedLanguageLevel1;
        }
        public string SameLanguageAssertion()
        {
            Thread.Sleep(3000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",20);
            string actualPopUpMsg1 =driver.FindElement(actualPopUpMsg).Text;
            return actualPopUpMsg1;
        }
        public void DeleteLanguage()
        {
           
            driver.FindElement(deleteIcon).Click();
        }
        public string DeleteAssertion()
        {
            Thread.Sleep(4000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",20);
            string actualPopUpDeleteMsg1= driver.FindElement(actualPopUpMsg).Text;
            return actualPopUpDeleteMsg1;
        }

    }
}


