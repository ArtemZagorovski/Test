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
    public class CantFindTicketsWithOnlyToTown
    {
        private HomePage homePage;
        private const string ToTown = "Москва";

        [Test()]
        public void FindTicketsWithOnlyToTown()
        {
            OpenHomePage();
            EnterToTownAndTryToClickFind();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private bool EnterToTownAndTryToClickFind()
        {
            homePage.AddToTown(ToTown);
            return homePage.FindButtonToBeClickable();
        }

        private void AssertErrorsVisible()
        {
            Assert.AreEqual(EnterToTownAndTryToClickFind(), false);
        }
    }
}
