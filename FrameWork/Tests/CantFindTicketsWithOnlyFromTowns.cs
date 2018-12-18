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
    public class CantFindTicketsWithOnlyFromTown
    {
        private HomePage homePage;
        private const string FromTown = "Минск";

        [Test()]
        public void FindTicketsWithOnlyFrom()
        {
            OpenHomePage();
            EnterFromTownAndTryToClickFind();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private bool EnterFromTownAndTryToClickFind()
        {
            homePage.AddFromTown(FromTown);
            return homePage.FindButtonToBeClickable();
        }

        private void AssertErrorsVisible()
        {
            Assert.AreEqual(EnterFromTownAndTryToClickFind(), false);
        }
    }
}
