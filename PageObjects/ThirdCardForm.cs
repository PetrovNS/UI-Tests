using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTest.PageObjects
{
    public class ThirdCardForm : Form
    {
        public ThirdCardForm() : base(By.XPath("//div[contains(@class,'page-indicator') and contains(text(),'3 / 4')]"), "Third card form") { }
    }
}
