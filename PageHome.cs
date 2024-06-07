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

            string pageString = driver.Title;                                                                       //Verify page title displays Demo Web Shop
            string PageTitle = "Demo Web Shop";
            Assert.That(pageString.Contains("Demo Web Shop"), $"Expected [{PageTitle}], but found[{pageString}]");


    }

}
}
