using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTest.PageObjects
{
    public class HomePage : Form
    {
        public HomePage() : base(By.XPath("//button[@class='start__button']"), "Home Page") { }

        private ILink LinkToNextPage => ElementFactory.GetLink(By.XPath("//a[@class='start__link']"), "Link to the next page");

        public void GoToNextPage() => LinkToNextPage.WaitAndClick();
    }
}
