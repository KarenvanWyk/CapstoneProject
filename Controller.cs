using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.IndexedDB;
using SikuliSharp;
using WindowsInput.Native;
using WindowsInput;
using System.Reactive.Joins;


namespace Capstone
{
    public class Controller
    {
        ISikuliSession session;
        IWebDriver driver;
        VirtualKeyCode key;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            session = Sikuli.CreateSession();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void HomePage()
        {
            PageHome.OpenHomePage(driver);
        }

        [Test]
        public void Login()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);
        }

        [Test]
        public void SelectCategory()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();  // Select the Jewelry option under the Categories section.  Jewelry downloads page is displayed

            List<string> urlList = new List<string>();                                                                // Verify that the url contains Jewelry
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));
        }

        [Test]
        public void ChangeDisplayView()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();  // Select the Jewelry option under the Categories section.  Jewelry downloads page is displayed

            List<string> urlList = new List<string>();                                                                // Verify that the url contains Jewelry
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();                                   // Select the List option under the View as dropdown

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();                         // Products will be displayed underneath each other
        }

        [Test]
        public void AddProduct()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();  // Select the Jewelry option under the Categories section.  Jewelry downloads page is displayed

            List<string> urlList = new List<string>();                                                                // Verify that the url contains Jewelry
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();                                   // Select the List option under the View as dropdown

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();                         // Products will be displayed underneath each other

            PageJewelry.Jewelry(driver, session, key);
        }

        [Test]
        public void Checkout()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();  // Select the Jewelry option under the Categories section.  Jewelry downloads page is displayed

            List<string> urlList = new List<string>();                                                                // Verify that the url contains Jewelry
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();                                   // Select the List option under the View as dropdown

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();                         // Products will be displayed underneath each other

            PageJewelry.Jewelry(driver, session, key);

            PageCart.ShoppingCart(driver, session, key);

        }

        [Test]
        public void LogOut()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();  // Select the Jewelry option under the Categories section.  Jewelry downloads page is displayed

            List<string> urlList = new List<string>();                                                                // Verify that the url contains Jewelry
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();                                   // Select the List option under the View as dropdown

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();                         // Products will be displayed underneath each other

            PageJewelry.Jewelry(driver, session, key);

            PageCart.ShoppingCart(driver, session, key);
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/a/img")).Click();                     // Click on the Demo Work Shop Logo. Home page is displayed
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();         // Select on the Logout link in the page header.  Home page with login option is displayed
         

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           driver.Dispose();
        }

    }
}