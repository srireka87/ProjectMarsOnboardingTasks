using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.Pages
{
    public class ProfileHomePage:CommonDriver
    {
        public ProfileHomePage(IWebDriver driver) :base(driver)
        {
        }
        private IWebElement ProfileTab => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
        private IWebElement LanguageTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        private IWebElement SkillTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));

        public void GoToProfileLangauges()
        {
           WaitHelpers.WaitToBeVisible(driver, "XPath","/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]", 3);
           ProfileTab.Click();
           LanguageTab.Click();
        }
        public void GoToProfileSkills()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath","/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]", 3);
            ProfileTab.Click();
            SkillTab.Click();
        }
       

    }
}
