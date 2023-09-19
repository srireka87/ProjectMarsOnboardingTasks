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
    public class LanguagesTabPage
    {
        public void AddNewLanguage(IWebDriver driver, string language, string level)

        {

            //Click AddNew Button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();


            //Add Newlanguage

            IWebElement addLanguageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguageTextBox.SendKeys(language);

            //Select the ALnguage Level
            IWebElement addLanguageLevelDropDown = driver.FindElement(By.TagName("select"));
            addLanguageLevelDropDown.SendKeys(level);

            //Click Add Button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

        }

        public string GetActualLanguageAssertion(IWebDriver driver)
        {
            //Get the added new language datas for validation
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 5);
            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualLanguage.Text;
        }

        public string GetActualLanguageLevelAssertion(IWebDriver driver)
        {
            //Get the added New Language Level datas for Validation
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 5);
            IWebElement actualLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualLanguageLevel.Text;
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
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 30);
            IWebElement deletedActualData = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedActualData.Text;
        }

        public void CloseTheDriver(IWebDriver driver)
        {
            driver.Quit();
        }

    }
}


