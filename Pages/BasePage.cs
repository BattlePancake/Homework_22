using Homework_22.Factory;
using OpenQA.Selenium;

namespace Homework_22.Pages
{
    internal class BasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();


        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        public static void Refresh() => Driver.GetDriver().Navigate().Refresh();
    }
}
