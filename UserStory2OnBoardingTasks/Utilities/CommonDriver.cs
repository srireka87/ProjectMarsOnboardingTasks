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
        protected IWebDriver driver;

        public CommonDriver(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
    [Binding]
    public sealed class Hooks1 
        {
            private IObjectContainer _container;
            public Hooks1(BoDi.IObjectContainer container)

            {
                this._container = container;
            }

            [BeforeScenario(Order = 1)]
        public void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _container.RegisterInstanceAs<IWebDriver>(driver);

        }

        [AfterScenario]
        public void CloseDriver()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }

        }
    }
}


