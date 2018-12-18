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
    public class OpenTimetableWithoutDate
    {
        private HomePage homePage;
        private const string FromTown = "Минск";
        private const string ToTown = "Москва";
        private const string ErrorMessage = "Укажите поля Откуда, Куда и Дата вылета";

        [Test()]

        public void SearchTickets()
        {
            OpenHomePage();
            ClickTimetableAndTryToFindFlytesWithoutDate();
            AssertErrorsVisible();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private void ClickTimetableAndTryToFindFlytesWithoutDate()
        {
            homePage.ClickTimetable();
            homePage.AddFromTownTimetable(FromTown);
            homePage.AddToTownTimetable(ToTown);
            homePage.ClickGetTimetable();
        }

        private void AssertErrorsVisible()
        {
            var messageText = homePage.GetErrorsMessages().Text;
            Assert.AreEqual(ErrorMessage, messageText);
        }
    }
}
