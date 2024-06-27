using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Wikipedia.Testing.Forms
{
    public class HeaderForm : Form
    {
        public HeaderForm() : base(By.ClassName("main-top"), "Wikipedia Main Page") { }
    }
}
