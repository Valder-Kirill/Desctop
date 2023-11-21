using Aquality.WinAppDriver.Applications;
using DesctopAuto.PageObject;
using DesctopAuto.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DesctopAuto.StepDefinitions
{
    [Binding]
    public class MainPageStepDefinitions
    {
        private MainPage MainPage => new MainPage();

        [Given(@"app is open")]
        public void GivenAppIsOpen()
        {
            DriverUtils.GetDriver();
            //AqualityServices.WinAppDriverLauncher.StartWinAppDriverIfRequired();
            AqualityServices.Application.Launch();
        }

        [When(@"fill in the document with '(.*)'")]
        public void WhenFillInTheDocumentWith(string text)
        {
            MainPage.DocumentTextFillIn(text);
        }

        [Then(@"is the document fill in")]
        public void ThenIsTheDocumentFillIn()
        {
            MainPage.GetDocumentText();
        }
    }
}
