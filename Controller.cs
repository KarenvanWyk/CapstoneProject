using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SikuliSharp;

namespace Capstone
{
    public class Controller
    {
        ISikuliSession session;
        IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            session = Sikuli.CreateSession();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void OpenHomePage()
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
            Thread.Sleep(500);

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
            Thread.Sleep(500);

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();                         // Products will be displayed underneath each other

            PageCart.AddtoCart(driver,session);

        }

        [Test]
        public void Checkout()
        {
            
        }

        [Test]
        public void ReturnToHomePage()
        {
            
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Dispose();
        }

    }
}