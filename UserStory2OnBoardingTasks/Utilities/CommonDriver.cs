using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStory2OnBoardingTasks.Utilities
{
    public class CommonDriver

    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void CloseDriver()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}


