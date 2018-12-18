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
    public class FindOfTicketsWorksTest
    {
        private HomePage homePage;
        private const string FromTown = "Минск";
        private const string ToTown = "Москва";

        [Test()]

        public void SearchTickets()
        {
            OpenHomePage();
            AddTownsAndClickFind();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private void AddTownsAndClickFind()
        {
            homePage.AddFromTown(FromTown);
            homePage.AddToTown(ToTown);
            homePage.ClickFindButton();
        }

        private void AssertErrorsVisible()
        {
            Assert.AreEqual(homePage.Url, "https://book.flyuia.com/RU/default/flights?");
        }
    }
}
