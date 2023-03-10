using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTest.PageObjects
{
    public class FirstCardForm : Form
    {
        public FirstCardForm() : base(By.XPath("//div[contains(@class, 'page-indicator') and contains(text(),'1 / 4')]"), "First card form") { }

        private ITextBox PasswordBox => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Password')]"), "Password input box");
        private ITextBox EmailBox => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'email')]"), "Email input box");
        private ITextBox DomainBox => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Domain')]"), "Domain input box");
        private IButton DropDownOpener => ElementFactory.GetButton(By.XPath("//div[@class='dropdown__opener']"), "Drop down opener");
        private ILabel Domain(int domainNumber) => ElementFactory.GetLabel(By.XPath($"//div[contains(@Class,'dropdown__list')]/div[{domainNumber}]"), "Select top level domain");
        private ILabel TermsAcception => ElementFactory.GetLabel(By.XPath("//label[@class='checkbox__label']"), "Terms and Conditions acceptance ");
        private IButton LinkToNextPage => ElementFactory.GetButton(By.XPath("//a[@class='button--secondary']"), "Link to the next page");

        public void InputEmail(string email) => EmailBox.ClearAndType(email);
        public void InputDomain(string domain) => DomainBox.ClearAndType(domain);
        public void InputPassword(string password) => PasswordBox.ClearAndType(password);
        public void SelectDomain(int domainNumber)
        {
            DropDownOpener.Click();
            Domain(domainNumber).Click();
        }
        public void AcceptTheTerms() => TermsAcception.Click();
        public void NextPage() => LinkToNextPage.Click();
    }
}
