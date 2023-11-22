using Aquality.WinAppDriver.Elements.Interfaces;
using Aquality.WinAppDriver.Forms;
using OpenQA.Selenium;

namespace SpecFlowProject.PageObjects
{
    public class MainPage : Form
    {
        private static ITextBox DocumentTextBox;

        public MainPage() : base(By.ClassName("Scintilla"), "Main page")
        {
            DocumentTextBox = ElementFactory.GetTextBox(By.Name("Scintilla"), "Document text box");
        }

        public void DocumentTextFillIn(string text)
        {
            DocumentTextBox.SendKeys(text);
        }

        public string GetDocumentText()
        {
            return DocumentTextBox.Text;
        }
    }
}
