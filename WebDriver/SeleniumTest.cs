using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium;

namespace Selenium
{
    public class Automatization
    {
        public static void Main(string[] args){
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flyuia.com/ua/ru/");
            IWebElement FirstTown = driver.FindElement(By.Id("mat-input-0 "));
            FirstTown.SendKeys("Минск");
            IWebElement SecondTown = driver.FindElement(By.Id("mat-input-1 "));
            SecondTown.SendKeys("Москва");
            IWebElement Button = driver.FindElement(By.Id("SEARCH_WIDGET_FORM_BUTTONS_SEARCH_FLIGHTS"));
            Button.Click();
        }
    }
}