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
        
        By addNewButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        By addLanguageTextBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
        By addLanguageLevelDropDown = By.TagName("select");
        By addButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        By actualLanguage = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By actualLanguageLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");


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

        public void UpdateLanguages(IWebDriver driver, string updateLanguage, string updateLevel)
        {

            //Click Update icon       
            IWebElement updateIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            updateIcon.Click();

            //Update the Language
            IWebElement updateLanguageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            updateLanguageTextBox.Clear();
            updateLanguageTextBox.SendKeys(updateLanguage);

            //update the  Language Level
            IWebElement updateLanguageLevelDropDown = driver.FindElement(By.TagName("select"));
            updateLanguageLevelDropDown.Click();
            updateLanguageLevelDropDown.SendKeys(updateLevel);

            //Click Update Button
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateButton.Click();

        }

        public string ActualUpdateLanguageAssertion(IWebDriver driver)
        {
            //Get the Updated New language  for validation
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",30);
            IWebElement actualUpdatedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualUpdatedLanguage.Text;

        }

        public string ActualUpdateLanguageLevelAssertion(IWebDriver driver)
        {

            //Get the upated New Language Level  for Validation
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WaitHelpers.WaitToBeVisible(driver,"XPath","//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]",30);
            IWebElement actualUpdatedLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualUpdatedLanguageLevel.Text;
        }

       
        public string SameLanguageAssertion(IWebDriver driver)
        {
            Thread.Sleep(3000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']",30);
            IWebElement actualPopUpMsg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return actualPopUpMsg.Text;
        }

        public void DeleteLanguage(IWebDriver driver)
        {

            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[last()]/span[2]/i"));
            deleteIcon.Click();
        }
        public string DeleteAssertion(IWebDriver driver)
        {
            Thread.Sleep(4000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 30);
            IWebElement actualPopUpMsg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Console.WriteLine(actualPopUpMsg.Text);
            return actualPopUpMsg.Text;
        }

        public void CloseTheDriver(IWebDriver driver)
        {
            driver.Quit();
        }

    }
}


