using Microsoft.VisualStudio.CodeCoverage;
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
            driver.FindElement(By.XPath("//*[@id=\"topcartlink\"]/a/span[1]")).Click();                   // Click on the  Shopping Cart Link in the page header.  Shopping cart page is displayed

            string path = "C:\\Training\\CapstoneProject\\Images\\Select_Country.png";                    // Click on the Country dropdown (Use Sikuli)  
            IPattern iPattern = Patterns.FromFile(path);
            session.Wait(iPattern);
            session.Click(iPattern);

            string path1 = "C:\\Training\\CapstoneProject\\Images\\American_Samoa.png";                   // Select American Samoa as the downdrop option (Use Sikuli)
            IPattern iPatterm1 = Patterns.FromFile(path1);
            session.Wait(iPatterm1);
            session.Click(iPatterm1);

            Thread.Sleep(500);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(key);

            string path2 = "C:\\Training\\CapstoneProject\\Images\\Zip_Code.png";                         // Insert 96799 into the Zipcode source field(Use Sikuli)
            IPattern iPatterm2 = Patterns.FromFile(path2);
            session.Click(iPatterm2);
            session.Type("96799");

            string path3 = "C:\\Training\\CapstoneProject\\Images\\T_and_C.png";                          // Select the Agree to TC & C checkbox(Use Sikuli)
            IPattern iPatterm3 = Patterns.FromFile(path3); 
            session.Wait(iPatterm3);
            session.Click(iPatterm3);

            string path4 = "C:\\Training\\CapstoneProject\\Images\\Checkout.png";                         // Click on the Checkout button(Use Sikuli)
            IPattern iPatterm4 = Patterns.FromFile(path4);
            session.Wait(iPatterm4);
            session.Click(iPatterm4);

            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[1]/h1")).Click();    // Checkout Page is displayed

            String PageHeader = "Checkout";                                                               // Verify that the page header is Checkout.  Page header is displayed as Checkout
            Assert.That(PageHeader.Contains("Checkout"));      }

    }
      
}

