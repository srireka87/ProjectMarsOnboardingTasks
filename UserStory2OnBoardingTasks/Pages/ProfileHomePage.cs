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
        public void GotoProfileLangauge(IWebDriver driver)
        {

            //Go to Profile Tab
            WaitHelpers.WaitToBeVisible(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]", 3);
            IWebElement profileTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
            profileTab.Click();

            //Go to Language tab
            IWebElement languageTab = driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
            languageTab.Click();
        }

    }
}
