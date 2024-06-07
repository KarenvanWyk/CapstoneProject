using OpenQA.Selenium;
using SikuliSharp;
using WindowsInput;
using WindowsInput.Native;


namespace Capstone
{
    internal class PageCart
    {
        public static void ShoppingCart(IWebDriver driver, ISikuliSession session, WindowsInput.Native.VirtualKeyCode key)

        {
            driver.FindElement(By.XPath("//*[@id=\"topcartlink\"]/a/span[1]")).Click();                        // Click on the  Shopping Cart Link in the page header.  Shopping cart page is displayed

            string path = "C:\\Training\\CapstoneProject\\Images\\Select_Country.png";                         // Click on the Country dropdown (Use Sikuli)  
            IPattern iPattern = Patterns.FromFile(path);
            session.Wait(iPattern);
            session.Click(iPattern);

            string path1 = "C:\\Training\\CapstoneProject\\Images\\American_Samoa.png";                        // Select American Samoa as the downdrop option (Use Sikuli)
            IPattern iPattern1 = Patterns.FromFile(path1);
            session.Wait(iPattern1);
            session.Click(iPattern1);

            Thread.Sleep(500);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(key);

            string path2 = "C:\\Training\\CapstoneProject\\Images\\Zip_Code.png";                              // Insert 96799 into the Zipcode source field(Use Sikuli)
            IPattern iPattern2 = Patterns.FromFile(path2);
            session.Wait(iPattern2);
            session.Click(iPattern2);
            session.Type("96799");

            string path3 = "C:\\Training\\CapstoneProject\\Images\\T_and_C.png";                               // Select the Agree to TC & C checkbox(Use Sikuli)
            IPattern iPattern3 = Patterns.FromFile(path3);
            session.Wait(iPattern3);
            session.Click(iPattern3);

            string path4 = "C:\\Training\\CapstoneProject\\Images\\Checkout.png";                              // Click on the Checkout button(Use Sikuli)
            IPattern iPattern4 = Patterns.FromFile(path4);
            session.Wait(iPattern4);
            session.Click(iPattern4);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[1]/h1")).Click();         // Checkout Page is displayed

            string headerString = driver.Title;
            string PageHeader = "Checkout";                                                                           // Verify that the page header is Checkout.  Page header is displayed as Checkout
            Assert.That(headerString.Contains("Checkout"), $"Expected [{PageHeader}], but found [{headerString}]");
    }
        public static void Logout(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/a/img")).Click();              // Click on the Demo Work Shop Logo. Home page is displayed
            
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();  // Select on the Logout link in the page header.  Home page with login option is displayed

            string loginString = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Text;
            string OptionLogin = "Log in";
            Assert.That(loginString.Contains("Log in"), $"Expected [{OptionLogin}], but found [{loginString}]");
        }

    }

}

