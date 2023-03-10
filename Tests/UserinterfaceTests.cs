using Aquality.Selenium.Browsers;
using UserinterfaceTest.PageObjects;
using UserinterfaceTest.Utils;

namespace UserinterfaceTest.Tests
{
    public class UserinterfaceTests : BaseTest
    {
        private const int FirstDomain = 2;
        private const int LastDomain = 11;
        private const int StringLength = 8;
        private const int NumberOfRequiredInterests = 3;
        private const int AllInterestsCount = 19;
        [Test]
        public void PathToThirdCard()
        {
            TestSteps.GoToFirstCardPage();
            FirstCardForm firstCard = new();
            Assert.IsTrue(firstCard.State.WaitForDisplayed(), "First card form is not open");
            var randomEmail = RandomGenerator.RandomStringLowerCase(StringLength);
            firstCard.InputEmail(randomEmail);
            firstCard.InputDomain(RandomGenerator.RandomStringLowerCase(StringLength));
            firstCard.InputPassword(RandomGenerator.RandomPassword(randomEmail));
            firstCard.SelectDomain(RandomGenerator.RandomNumberFromRange(FirstDomain, LastDomain));
            firstCard.AcceptTheTerms();
            AqualityServices.Logger.Info("Go to second card page");
            firstCard.NextPage();
            SecondCardForm secondCard = new();
            Assert.IsTrue(secondCard.State.WaitForDisplayed(), "Second card form is not open");
            secondCard.UnsellectAll();
            secondCard.Click3RandomInterests(RandomGenerator.GetArrayUniqueRandomNumbers(NumberOfRequiredInterests, AllInterestsCount));
            secondCard.UploadImage(DataManager.dataObject.ImagePath);
            AqualityServices.Logger.Info("Go to third card page");
            secondCard.ClickNextButton();
            ThirdCardForm thirdCard = new();
            Assert.IsTrue(thirdCard.State.WaitForDisplayed(), "Third card form is not open");
        }
        [Test]
        public void HideHelpForm()
        {
            TestSteps.GoToFirstCardPage();
            HelpForm helpForm = new();
            AqualityServices.Logger.Info("Hide the help form");
            helpForm.HideHelpForm();
            Assert.IsTrue(helpForm.HelpFormIsHidden(), "Help form is open");
        }
        [Test]
        public void AcceptCookies()
        {
            TestSteps.GoToFirstCardPage();
            CookiesForm cookiesForm = new();
            AqualityServices.Logger.Info("Accept cookies");
            cookiesForm.AcceptCookies();
            Assert.IsFalse(cookiesForm.State.IsExist, "Cookies form still exists");
        }
        [Test]
        public void TimerValidation()
        {
            TestSteps.GoToFirstCardPage();
            TimerForm timerForm = new();
            StringAssert.Contains(DataManager.dataObject.TimerStart, timerForm.GetActualTime(), "The time doesn't match");
        }
    }
}