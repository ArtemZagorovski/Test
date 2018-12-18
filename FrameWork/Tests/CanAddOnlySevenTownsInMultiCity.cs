using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace WebDriver
{
    [TestFixture()]
    public class CanAddOnlySevenTownsInMultiCity
    {
        private HomePage homePage;

        [Test()]
        public void AddTowmsInMultiCity()
        {
            OpenHomePage();
            ClikEightTimesAddFlight();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private bool ClikEightTimesAddFlight()
        {
            homePage.ClickMultiSity();
            homePage.ClickAddFlight();
            return homePage.AddFlightToBeClickable()
        }

        private void AssertErrorsVisible()
        {
            Assert.AreEqual(ClikEightTimesAddFlight(), false);
        }
    }
}
