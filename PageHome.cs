using OpenQA.Selenium;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;


namespace Capstone
{
    internal class PageHome
    {
        public static void OpenHomePage(IWebDriver driver)
        {

            driver.Navigate().GoToUrl(" https://demowebshop.tricentis.com/");
            string PageTitle = driver.Title;
            Assert.True(PageTitle.Contains("Demo Web Shop"));                                       //Verify page title displays Demo Web Shop

        }

    }
}
