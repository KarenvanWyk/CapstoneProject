using OpenQA.Selenium;

namespace Capstone
{
    internal class PageLogin
    {
        public static void Login (IWebDriver driver)
        {
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();                                                     // Login page is displayed.  Click on Login link in the page header

            string displayString = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[1]/strong")).Text;            // Verify that the Entry box header is Returning Customer
            string DisplayNameAttribute = "Returning Customer";
            Assert.That(displayString.Contains("Returning Customer"), $"Expected [{DisplayNameAttribute}], but found[{displayString}]");

            driver.FindElement(By.Id("Email")).SendKeys(Config.email);                                                                                            // Enter email adress
            Thread.Sleep(300);

            driver.FindElement(By.Id("Password")).SendKeys(Config.password);                                                                                      // Enter password
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")).Click();                     // Home page is displayed.  Click Login button

            string emailString = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[1]/a")).Text;                                   // Verify user email is displayed in page header
            string EmailAddressAttribute = "karenvw@pepkorit.com";                                                                             
            Assert.That(emailString.Contains("karenvw@pepkorit.com"), $"Expected [{EmailAddressAttribute}], but found [{emailString}]");
        }
    }
}
