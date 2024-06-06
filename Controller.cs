using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V123.IndexedDB;
using SikuliSharp;
using WindowsInput.Native;
using WindowsInput;
using System.Reactive.Joins;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using System.Xml.Linq;


namespace Capstone
{
    public class Controller
    {
        ISikuliSession session;
        IWebDriver driver;
        VirtualKeyCode key;
        static ExtentReports reports;


        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            session = Sikuli.CreateSession();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            reports = new ExtentReports();
            var htmlReporter = new ExtentSparkReporter("C:\\Training\\CapstoneProject\\Reports\\CapstoneProjectSpark.html");
            reports.AttachReporter(htmlReporter);
            
        }

        [Test]
        public void HomePage()
        {
            ExtentTest test = reports.CreateTest("TEST CASE:  Open Home Page");
            try
            {
                PageHome.OpenHomePage(driver);
                test.Pass("OPEN HOME PAGE: TEST CASE PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void Login()
        {
            ExtentTest test = reports.CreateTest("TEST CASE:  Login");
            try
            {
                PageHome.OpenHomePage(driver);
                test.Pass("OPEN HOME PAGE: TEST CASE PASSED");

                PageLogin.Login(driver);
                test.Pass("LOG IN:  TEST CASE PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }    

        [Test]
        public void SelectCategory()
        {
            ExtentTest test = reports.CreateTest("TEST CASE:  Login");
            try
            {
                PageHome.OpenHomePage(driver);
                test.Pass("OPEN HOME PAGE: TEST CASE PASSED");

                PageLogin.Login(driver);
                test.Pass("LOG IN:  TEST CASE PASSED");

                PageJewelry.SelectOptionJewelry(driver);
                test.Pass("SELECT OPTION JEWELRY:  TEST CASE PASSED");

                PageJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW:  TEST CASE PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void JewelryDesign()
        {
            ExtentTest test = reports.CreateTest("TEST CASE:  Login");
            try
            {
                PageHome.OpenHomePage(driver);
                test.Pass("OPEN HOME PAGE: TEST CASE PASSED");

                PageLogin.Login(driver);
                test.Pass("LOG IN:  TEST CASE PASSED");

                PageJewelry.SelectOptionJewelry(driver);
                test.Pass("SELECT OPTION JEWELRY:  TEST CASE PASSED");

                PageJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW:  TEST CASE PASSED");

                PageJewelry.CreateYourJewelry(driver, session, key);
                test.Pass("CREATE YOUR JEWELRY:  TEST CASE PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void ShoppingCart()
        {
            ExtentTest test = reports.CreateTest("TEST CASE:  Login");
            try
            {
                PageHome.OpenHomePage(driver);
                test.Pass("OPEN HOME PAGE: TEST CASE PASSED");

                PageLogin.Login(driver);
                test.Pass("LOG IN:  TEST CASE PASSED");

                PageJewelry.SelectOptionJewelry(driver);
                test.Pass("SELECT OPTION JEWELRY:  TEST CASE PASSED");

                PageJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW:  TEST CASE PASSED");

                PageJewelry.CreateYourJewelry(driver, session, key);
                test.Pass("CREATE YOUR JEWELRY:  TEST CASE PASSED");

                PageCart.ShoppingCart(driver, session, key);
                test.Pass("SHOPPING CART:  TEST CASE PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void LogOut()
        {
            ExtentTest test = reports.CreateTest("TEST CASE:  Login");
            try
            {
                PageHome.OpenHomePage(driver);
                test.Pass("OPEN HOME PAGE: TEST CASE PASSED");

                PageLogin.Login(driver);
                test.Pass("LOG IN:  TEST CASE PASSED");

                PageJewelry.SelectOptionJewelry(driver);
                test.Pass("SELECT OPTION JEWELRY:  TEST CASE PASSED");

                PageJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW:  TEST CASE PASSED");

                PageJewelry.CreateYourJewelry(driver, session, key);
                test.Pass("CREATE YOUR JEWELRY:  TEST CASE PASSED");

                PageCart.ShoppingCart(driver, session, key);
                test.Pass("SHOPPING CART:  TEST CASE PASSED");

                PageCart.Logout(driver);
                test.Pass("LOG OUT:  TEST CASE PASSED");

            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           driver.Dispose();
           reports.Flush();
           reports = null;
        }

    }
}