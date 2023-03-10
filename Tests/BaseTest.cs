
using Aquality.Selenium.Browsers;
using UserinterfaceTest.Utils;

namespace UserinterfaceTest.Tests
{
    public abstract class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            AqualityServices.Browser.GoTo(DataManager.dataObject.MainPageUrl);
            AqualityServices.Browser.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Quit();
        }
    }
}