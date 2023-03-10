using Aquality.Selenium.Browsers;
using UserinterfaceTest.PageObjects;

namespace UserinterfaceTest.Tests
{
    public static class TestSteps
    {
        public static void GoToFirstCardPage()
        {
            AqualityServices.Logger.Info("Go to home page");
            HomePage homePage = new();
            Assert.IsTrue(homePage.State.WaitForDisplayed(), "Main page is not open");
            AqualityServices.Logger.Info("Go to first card page");
            homePage.GoToNextPage();
        }
    }
}
