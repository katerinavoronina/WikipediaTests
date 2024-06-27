using Aquality.Selenium.Browsers;
using TechTalk.SpecFlow;
using Wikipedia.Testing.Configurations;
using Wikipedia.Testing.Forms;

namespace Wikipedia.Testing.StepDefinitions
{
    [Binding]
    public class WikipediaSteps
    {
        private readonly HeaderForm mainPage = new();
        private readonly LeftMenu leftMenu = new();

        [When(@"I open Wikipedia main page")]
        public void WhenIOpenWikipediaMainPage()
        {
            var browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(Configuration.BaseUrl);
        }

        [Then(@"The wikipedia main page is opened")]
        public void ThenTheWikipediaMainPageIsOpened()
        {
            Assert.IsTrue(mainPage.State.WaitForDisplayed(), "The wikipedia main page is opened");
        }

        [Then(@"The '([^']*)' element is correctly displayed")]
        public void ThenTheElementIsCorrectlyDisplayed(string elementName)
        {
            Assert.That(leftMenu.Dump.Compare(elementName), Is.EqualTo(0), $"The [{elementName}] element is correctly displayed");
        }
    }
}
