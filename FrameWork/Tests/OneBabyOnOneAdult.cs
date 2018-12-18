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
    public class OneBabyOnOneChildTest
    {
        private HomePage homePage;
        private const string ErrorMessage = "Каждый младенец может путещевствовать как минимум с одним взрослым";

        [Test()]
        public void OneBabyOnOneAdult()
        {
            OpenHomePage();
            AddTwoBabys();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private void AddTwoBabys()
        {
            homePage.AddPassengers();
            homePage.PlusBaby();
            homePage.PlusBaby();
        }

        private void AssertErrorsVisible()
        {
            var messageText = homePage.GetErrorsMessages().Text;
            Assert.AreEqual(ErrorMessage, messageText);
        }
    }
}
