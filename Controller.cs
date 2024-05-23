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
            PageJewelry.SelectOptionJewelry(driver);
            PageJewelry.ChangeDisplayView(driver);
        }

        [Test]
        public void AddProduct()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);
            PageJewelry.SelectOptionJewelry(driver);
            PageJewelry.ChangeDisplayView(driver);
            PageJewelry.SelectJewelryType(driver, session, key);
        }

        [Test]
        public void Checkout()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);
            PageJewelry.SelectOptionJewelry(driver);
            PageJewelry.ChangeDisplayView(driver);
            PageJewelry.SelectJewelryType(driver, session, key);
            PageCart.ShoppingCart(driver, session, key);

        }

        [Test]
        public void LogOut()
        {
            PageHome.OpenHomePage(driver);
            PageLogin.Login(driver);
            PageJewelry.SelectOptionJewelry(driver);
            PageJewelry.ChangeDisplayView(driver);
            PageJewelry.SelectJewelryType(driver, session, key);
            PageCart.ShoppingCart(driver, session, key);
            PageCart.Logout(driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           driver.Dispose();
        }

    }
}