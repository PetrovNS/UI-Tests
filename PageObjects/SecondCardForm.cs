using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UserinterfaceTest.Utils;

namespace UserinterfaceTest.PageObjects
{
    public class SecondCardForm : Form
    {
        public SecondCardForm() : base(By.XPath("//div[contains(@class,'page-indicator') and contains(text(),'2 / 4')]"), "Second card form") { }

        private ILabel UnsellectAllButton => ElementFactory.GetLabel(By.XPath("//label[@for='interest_unselectall']"), "Unsellect all check box");
        private IButton UploadImageBtn => ElementFactory.GetButton(By.XPath("//a[contains(@class,'upload-button')]"), "Upload button");
        private IList<ILabel> ListOfInterests => ElementFactory.FindElements<ILabel>(By.XPath("//label[@class='checkbox__label']"), "List of check boxes");
        private IButton NextButton => ElementFactory.GetButton(By.XPath("//button[contains(@class,'white button')]"), "Button to the next page");

        public void UnsellectAll() => UnsellectAllButton.Click();
        public void Click3RandomInterests(int[] indexes)
        {
            foreach (var item in indexes)
            {
                ListOfInterests[item].Click();
            }
        }
        public void UploadImage(string imagePath)
        {
            UploadImageBtn.Click();
            InputSimulator.UploadImage(imagePath);
        }
        public void ClickNextButton()
        {
            NextButton.State.WaitForEnabled();
            NextButton.Click();
        }
    }
}
