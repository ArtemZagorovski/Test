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

        By multiCity = By.Id("SEARCH_WIDGET_FORM_BUTTONS_MULTICITY");
        By addFlight = By.CssSelector("button.add-flight > div.caption");
        By clickTimetable = By.CssSelector("a.chosen-single.chosen-default");
        By chooseFromTownTimetable = By.CssSelector("input.chosen-search-input");
        By chooseToTownTimetable = By.CssSelector("#airport_2_chosen .chosen-search-input");
        By clickGetTimetable = By.Id("get_timetable_btn");
        By addPassenger = By.CssSelector(".ng-tns-c9-2 .value-as-text-container");
        By plusBaby = By.CssSelector(".sw-row:nth-child(3) > .set-val-btn:nth-child(3)");
        By plusChild = By.XPath("//div[3]/div[2]/button[2]");
        By minusAdult = By.CssSelector("button.set-val-btn");
        By fromTown = By.Id("mat-input-0");
        By toTown = By.Id("mat-input-1");
        By fromDate = By.CssSelector(".ng-star-inserted .value-as-text-container");
        By enterPromocode = By.CssSelector(".focus-trap:nth-child(1)");
        By findButton = By.XPath("//sw-search-flights/form/button");
        By oneWayTicket = By.Id("SEARCH_WIDGET_FORM_BUTTONS_ONE_WAY");
        By errorsMessages = By.ClassName("messages");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void ClickMultiSity()
        {
            driver.FindElement(multiCity).Click();
        }

        public void ClickAddFlight()
        {
            for (int i = 0; i < 7;i++)
            driver.FindElement(multiCity).Click();
        }

        public bool AddFlightToBeClickable()
        {
            var clickble = driver.FindElement(addFlight);
            if (clickble.Enabled)
                return true;
            return false;
        }

        public void ClickTimetable()
        {
            driver.FindElement(clickTimetable).Click();
        }

        public void AddFromTownTimetable(string value)
        {
            driver.FindElement(chooseFromTownTimetable).SendKeys(value);
        }

        public void AddToTownTimetable(string value)
        {
            driver.FindElement(chooseToTownTimetable).SendKeys(value);
        }

        public void ClickGetTimetable()
        {
            driver.FindElement(clickGetTimetable).Click();
        }

        public void ClickOneWayTicket()
        {
            driver.FindElement(oneWayTicket).Click();
        }

        public bool FromDateToBeClickable()
        {
            var clickble = driver.FindElement(fromDate);
            if (clickble.Enabled)
                return true;
            return false;
        }

        public void AddPassengers()
        {
            driver.FindElement(addPassenger).Click();
        }

        public void PlusChild()
        {
            driver.FindElement(plusChild).Click();
        }

        public void MinusAdult()
        {
            driver.FindElement(minusAdult).Click();
        }

        public void PlusBaby()
        {
            driver.FindElement(plusBaby).Click();
        }

        public void AddFromTown(string value)
        {
            driver.FindElement(fromTown).SendKeys(value);
        }

        public void AddToTown(string value)
        {
            driver.FindElement(toTown).SendKeys(value);
        }

        public void AddPromocode(string value)
        {
            driver.FindElement(enterPromocode).SendKeys(value);
        }

        public void ClickFindButton()
        {
            driver.FindElement(findButton).Click();
        }

        public bool FindButtonToBeClickable()
        {
            var clickble=driver.FindElement(findButton);
            if (clickble.Enabled)
                return true;
            return false;
        }

        public IWebElement GetErrorsMessages()
        {
            return driver.FindElement(errorsMessages);
        }
    }
}
