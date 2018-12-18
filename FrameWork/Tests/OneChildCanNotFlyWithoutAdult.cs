using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObject.Test
{
    [TestFixture()]
    public class OneChildCanNotFlyWithoutAdult
    {
        private HomePage homePage;
        private const string ErrorMessage = "Дети не могут путшестововать без взрослых";
        [Test()]
        public void OneChildCanNotFlyWithoutAdult()
        {
            OpenHomePage();
            PLusChildMinusAdult();           
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
            this.homePage = homePage;
        }

        private void PLusChildMinusAdult()
        {
            homePage.PlusChild();
            homePage.MinusAdult();
        }

        private void AssertErrorsVisible()
        {
            var messageText = homePage.GetErrorsMessages().Text;
            Assert.AreEqual(ErrorMessage, messageText);
        }
    }
}
