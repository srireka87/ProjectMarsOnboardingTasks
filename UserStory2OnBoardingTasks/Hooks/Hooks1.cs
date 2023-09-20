using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace UserStory2OnBoardingTasks.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private IObjectContainer _container;
       public Hooks1(IObjectContainer container)
        
        {
            this._container= container;     
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
           IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _container.RegisterInstanceAs<IWebDriver>(driver);

        }

        [AfterScenario]
        public void AfterScenario()
        {
           var driver= _container.Resolve<IWebDriver>();
            if(driver !=null)
            {
                driver.Quit();
            }
        }
    }
}