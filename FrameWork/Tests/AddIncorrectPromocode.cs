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
    public class AddIncorrectPromocodeTest
    {
        private HomePage homePage;
        private const string ErrorMessage = "Промокод недействителен. Этот промокод не существует.";
        private const string FromTown = "Минск";
        private const string ToTown = "Москва";

        [Test()]

        public void AddIncorrectPromocode()
        {
            OpenHomePage();
            AddTownsAndEnterPromocode();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private void AddTownsAndEnterPromocode()
        {
            homePage.AddFromTown(FromTown);
            homePage.AddToTown(ToTown);
            homePage.AddPromocode(1111);
            homePage.ClickFindButton();
        }

        private void AssertErrorsVisible()
        {
            var messageText = homePage.GetErrorsMessages().Text;
            Assert.AreEqual(ErrorMessage, messageText);
        }
    }
}
