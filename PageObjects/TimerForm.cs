using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTest.PageObjects
{
    public class TimerForm : Form
    {
        public TimerForm() : base(By.XPath("//div[contains(@class,'timer')]"), "Timer form") { }

        public string GetActualTime() => FormElement.GetText();
    }
}
