using OpenQA.Selenium;
using SikuliSharp;
using WindowsInput.Native;
using WindowsInput;
using OpenQA.Selenium.DevTools.V85.IndexedDB;

namespace Capstone
{
    internal class PageJewelry
    {
        public static void Jewelry(IWebDriver driver, ISikuliSession session, WindowsInput.Native.VirtualKeyCode key)
        {
            string path = "C:\\Training\\CapstoneProject\\Images\\Create_Your_Own.png";                   // Click on the product labled Create Your Own Jewelry image (Use Sikuli).  Product Page will be displayed
            IPattern iPattern = Patterns.FromFile(path);
            session.Wait(iPattern);
            session.Click(iPattern);

            string path1 = "C:\\Training\\CapstoneProject\\Images\\\\Material.png";                      // Select the Gold (1mm) option from the Material dropdown (Use Sikuli)
            IPattern iPatterm1 = Patterns.FromFile(path1);
            session.Wait(iPatterm1);
            session.Click(iPatterm1);

            string path2 = "C:\\Training\\CapstoneProject\\Images\\\\Gold1mm.png";                        // Select the Gold (1mm) option from the Material dropdown (Use Sikuli)
            IPattern iPatterm2 = Patterns.FromFile(path2);
            session.Wait(iPatterm2);
            session.Click(iPatterm2);

            Thread.Sleep(500);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(key);

            string path3 = "C:\\Training\\CapstoneProject\\Images\\Length.png";                           // Enter 30 into the Length in cm source field (Use Sikuli)
            IPattern iPatterm3 = Patterns.FromFile(path3);
            session.Click(iPatterm3);
            session.Type("30");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            string path4 = "C:\\Training\\CapstoneProject\\Images\\Heart.png";                            // Select the Heart radio button option under Pendant(Use Sikuli)
            IPattern iPatterm4 = Patterns.FromFile(path4);
            session.Click(iPatterm4);

            string path5 = "C:\\Training\\CapstoneProject\\Images\\Quantity.png";                        // Increase Quantity to 2 (Use Sikuli)
            IPattern iPatterm5 = Patterns.FromFile(path5);
            session.Click(iPatterm5);
            sim.Keyboard.KeyPress(VirtualKeyCode.BACK);
            session.Type("2");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            string path6 = "C:\\Training\\CapstoneProject\\Images\\Add_to_Cart.png";                      // Click on the Add to cart button (Use Sikuli)
            IPattern iPatterm6 = Patterns.FromFile(path6);
            session.Click(iPatterm6);

        }

    }
}

