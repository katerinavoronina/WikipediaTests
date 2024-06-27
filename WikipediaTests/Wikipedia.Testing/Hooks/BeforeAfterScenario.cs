using Aquality.Selenium.Browsers;
using TechTalk.SpecFlow;

namespace Wikipedia.Testing.Hooks
{
    [Binding]
    public class BeforeAfterScenario
    {
        [AfterScenario]
        public void CloseBrowser()
        {
            AqualityServices.Browser.Quit();
        }
    }
}
