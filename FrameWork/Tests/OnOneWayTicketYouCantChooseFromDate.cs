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
    public class OnOneWayTicketYouCantChooseFromDate
    {
        private HomePage homePage;

        [Test()]
        public void OneWayTicket()
        {
            OpenHomePage();
            TryToClickFromDate();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private bool TryToClickFromDate()
        {
            return homePage.FromDateToBeClickable();
        }

        private void AssertErrorsVisible()
        {
            Assert.AreEqual(TryToClickFromDate(), false);
        }
    }
}
