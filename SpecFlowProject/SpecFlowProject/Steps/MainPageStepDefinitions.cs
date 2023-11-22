using Aquality.WinAppDriver.Applications;
using SpecFlowProject.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public class MainPageStepDefinitions
    {
        [Given(@"app is open")]
        public void GivenAppIsOpen()
        {
            AqualityServices.WinAppDriverLauncher.StartWinAppDriverIfRequired();
            AqualityServices.Application.Launch();
        }

        [When(@"fill in the document with '(.*)'")]
        public void WhenFillInTheDocumentWith(string text)
        {
            new MainPage().DocumentTextFillIn(text);
        }

        [Then(@"is the document fill in")]
        public void ThenIsTheDocumentFillIn()
        {
            new MainPage().GetDocumentText();
        }
    }
}
