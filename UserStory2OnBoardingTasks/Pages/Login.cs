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
   public class Login:CommonDriver
    {
       public Login(IWebDriver driver)
        {
            this.driver = driver;
        } 
        
         By signInButton = By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
         By emailAddressTextbox = By.Name("email");
         By passwordTextbox = By.Name("password");
         By rememberMeCheckbox = By.Name("rememberDetails");
         By loginButton = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");
         By hiSrireka = By.XPath("//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/span[1]");
        
        public void LoginFunction(string email,string password)
        {
            driver.FindElement(signInButton).Click();
            driver.FindElement(emailAddressTextbox).SendKeys(email);
            driver.FindElement(passwordTextbox).SendKeys(password);
            driver.FindElement(rememberMeCheckbox).Click();
            driver.FindElement(loginButton).Click();
        }
        public void LoginAssertion()

        {
            Thread.Sleep(4000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/span[1]",20);
            string actualUserName =driver.FindElement(hiSrireka).Text;
            Assert.That(actualUserName =="Hi Srireka","Login Unsuccessful");
            Console.Out.WriteLine(actualUserName);
        }

    }
}
    
