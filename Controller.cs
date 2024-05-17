using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Capstone
{
    public class Controller
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver = new ChromeDriver();
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
            
        }

        [Test]
        public void ChangeDisplayView()
        {
            
        }

        [Test]
        public void AddProduct()
        {
            
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