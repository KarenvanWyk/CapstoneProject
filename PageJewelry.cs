using OpenQA.Selenium;
using SikuliSharp;
using WindowsInput.Native;
using WindowsInput;
using OpenQA.Selenium.DevTools.V85.IndexedDB;

namespace Capstone
{
    internal class PageJewelry
    {
        public static void SelectOptionJewelry(IWebDriver driver)
        {
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();  // Select the Jewelry option under the Categories section.  Jewelry downloads page is displayed

            List<string> urlList = new List<string>();                                                                // Verify that the url contains Jewelry
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));

        }

        public static void ChangeDisplayView(IWebDriver driver) 
        {
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();  // Select the Jewelry option under the Categories section.  Jewelry downloads page is displayed

            List<string> urlList = new List<string>();                                                                // Verify that the url contains Jewelry
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();                                   // Select the List option under the View as dropdown

            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();                         // Products will be displayed underneath each other

        }


        public static void CreateYourJewelry(IWebDriver driver, ISikuliSession session, WindowsInput.Native.VirtualKeyCode key)
        {
            string path = "C:\\Training\\CapstoneProject\\Images\\Create_Your_Own.png";                   // Click on the product labled Create Your Own Jewelry image (Use Sikuli).  Product Page will be displayed
            IPattern iPattern = Patterns.FromFile(path);
            session.Wait(iPattern);
            session.Click(iPattern);

            string path1 = "C:\\Training\\CapstoneProject\\Images\\Material.png";                      // Select the Gold (1mm) option from the Material dropdown (Use Sikuli)
            IPattern iPattern1 = Patterns.FromFile(path1);
            session.Wait(iPattern1);
            session.Click(iPattern1);

            string path2 = "C:\\Training\\CapstoneProject\\Images\\Gold1mm.png";                        // Select the Gold (1mm) option from the Material dropdown (Use Sikuli)
            IPattern iPattern2 = Patterns.FromFile(path2);
            session.Wait(iPattern2);
            session.Click(iPattern2);

            Thread.Sleep(500);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(key);

            string path3 = "C:\\Training\\CapstoneProject\\Images\\Length.png";                           // Enter 30 into the Length in cm source field (Use Sikuli)
            IPattern iPattern3 = Patterns.FromFile(path3);
            session.Click(iPattern3);
            session.Type("30");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            string path4 = "C:\\Training\\CapstoneProject\\Images\\Heart.png";                            // Select the Heart radio button option under Pendant(Use Sikuli)
            IPattern iPattern4 = Patterns.FromFile(path4);
            session.Click(iPattern4);

            string path5 = "C:\\Training\\CapstoneProject\\Images\\Quantity.png";                        // Increase Quantity to 2 (Use Sikuli)
            IPattern iPattern5 = Patterns.FromFile(path5);
            session.Click(iPattern5);
            sim.Keyboard.KeyPress(VirtualKeyCode.BACK);
            session.Type("2");

            string path6 = "C:\\Training\\CapstoneProject\\Images\\Add_to_Cart.png";                      // Click on the Add to cart button (Use Sikuli)
            IPattern iPattern6 = Patterns.FromFile(path6);
            session.Click(iPattern6);

        }

    }
}

