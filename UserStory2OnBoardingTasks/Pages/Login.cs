using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStory2OnBoardingTasks.Utilities;

namespace UserStory2OnBoardingTasks.Pages
{
   public class Login
    {
        public void LoginFunction(IWebDriver driver)
        {
            //ChromeDriver Maximise and go to ProjectMars
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //Select Signin
            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signInButton.Click();

           // WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\\\"home\\\"]/div/div/div[1]/div/a", 3);

            //Enter EmailAddress
            IWebElement emailAddressTextbox = driver.FindElement(By.Name("email"));
            emailAddressTextbox.SendKeys("srireka87@gmail.com");

            //Enter Password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("Rosesri@23");

            //Select Remember me checkbox
            IWebElement rememberMeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            rememberMeCheckbox.Click();

            //Click login Button

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();

        }
        public void LoginAssertion(IWebDriver driver)

        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/span[1]", 5);
            IWebElement hiSrireka = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/span[1]"));
            Assert.That(hiSrireka.Text =="Hi Srireka","Login Unsuccessful");
            Console.Out.WriteLine(hiSrireka.Text);
        }

    }
}
    
