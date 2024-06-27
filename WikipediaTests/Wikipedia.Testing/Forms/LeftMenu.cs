using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Wikipedia.Testing.Forms
{
    public class LeftMenu : Form
    {
        private ILabel LogoLabel => FormElement.FindChildElement<ILabel>(By.Id("p-logo"), "Logo");

        public LeftMenu() : base(By.Id("mw-panel"), "Left Menu") { }

        protected override IDictionary<string, IElement> ElementsForVisualization => new Dictionary<string, IElement>()
        {
            { "Logo", LogoLabel }
        };
    }
}
