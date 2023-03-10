using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTest.PageObjects
{
    public class CookiesForm : Form
    {
        public CookiesForm() : base(By.XPath("//div[@class='cookies']"), "Cookies form") { }

        private IButton AcceptCookiesBtn => ElementFactory.GetButton(By.XPath("//button[contains(@class,'transparent')]"), "Accept cookies button");

        public void AcceptCookies() => AcceptCookiesBtn.WaitAndClick();
    }
}
