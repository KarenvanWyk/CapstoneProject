using OpenQA.Selenium;

namespace Capstone
{
    internal class PageHome
    {
        public static void OpenHomePage(IWebDriver driver)
        {

            driver.Navigate().GoToUrl(" https://demowebshop.tricentis.com/");
            String PageTitle = driver.Title;
            Assert.True(PageTitle.Contains("Demo Web Shop"));                                       //Verify page title displays Demo Web Shop

        }
    }
}
