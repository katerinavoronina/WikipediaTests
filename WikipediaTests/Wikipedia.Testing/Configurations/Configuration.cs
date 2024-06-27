using Aquality.Selenium.Core.Utilities;
using System.Reflection;

namespace Wikipedia.Testing.Configurations
{
    public static class Configuration
    {
        private const string TestDataConfigPath = "Resources.TestData.config.json";
        private const string BaseUrlKey = "baseUrl";

        public static string BaseUrl => new JsonSettingsFile(TestDataConfigPath, Assembly.GetCallingAssembly()).GetValue<string>(BaseUrlKey);
    }
}
