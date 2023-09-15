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
        public void GotoProfileLangauge()
        {
            IWebElement profileTab = driver.FindElement(By.LinkText("/Account/Profile"));
            profileTab.Click();


        }

    }
}
