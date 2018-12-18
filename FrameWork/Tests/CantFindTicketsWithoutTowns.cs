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
    public class CantFindTicketsWithoutTowns
    {
        private HomePage homePage;

        [Test()]
        public void FindTicketsWithoutTowns()
        {
            OpenHomePage();
            TryToClickFindButton();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private bool TryToClickFindButton()
        {
            return homePage.FindButtonToBeClickable();
        }

        private void AssertErrorsVisible()
        {
            Assert.AreEqual(TryToClickFindButton(),false);
        }
    }
}
