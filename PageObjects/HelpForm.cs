using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTest.PageObjects
{
    public class HelpForm : Form
    {
        public HelpForm() : base(By.XPath("//div[@class='help-form']"), "Help form") { }

        private IButton HideFormBtn => ElementFactory.GetButton(By.XPath("//button[contains(@class,'to-bottom')]"), "Hide help form button");
        private ILabel HiddenForm => ElementFactory.GetLabel(By.XPath("//div[contains(@class,'is-hidden')]"), "Hidden form");

        public void HideHelpForm() => HideFormBtn.Click();
        public bool HelpFormIsHidden() => HiddenForm.State.WaitForDisplayed();
    }
}
