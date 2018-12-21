using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AirlinesTestingApp.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private const string Url = "https://www.flyuia.com/by/ru/home";

        By addPassenger = By.CssSelector(".ng-tns-c9-2 .value-as-text-container");
        By plusBaby = By.Xpath("//div[3]/button[2]");
        By errorsMessages = By.ClassName("messages");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void AddPassengers(){
            driver.FindElement(addPassenger).Click();
        }

        public void PlusBaby()
        {
            driver.FindElement(plusBaby).Click();
        }

        public IWebElement GetErrorsMessages()
        {
            return driver.FindElement(errorsMessages);
        }
    }
}
