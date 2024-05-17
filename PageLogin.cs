using OpenQA.Selenium;

namespace Capstone
{
    internal class PageLogin
    {
        public static void Login (IWebDriver driver)
        {
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();                                   // Login page is displayed.  Click on Login link in the page header

            String DisplayNameAttribute = "Returning Customer";                                                                                 // Verify that the Entry box header is Returning Customer
            Assert.That(DisplayNameAttribute.Contains("Returning Customer"));

            driver.FindElement(By.Id("Email")).SendKeys(Config.email);                                                                          // Enter email adress
            Thread.Sleep(300);

            driver.FindElement(By.Id("Password")).SendKeys(Config.password);                                                                    // Enter password
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")).Click();  // Home page is displayed.  Click Login button

            String EmailAddressAttribute = "karenvw@pepkorit.com";                                                                             // Verify user email is displayed in page header
            Assert.That(EmailAddressAttribute.Contains("karenvw@pepkorit.com"));


        }

    }
}
