using OpenQA.Selenium;
using SikuliSharp;

namespace Capstone
{
    internal class PageCart
    {
        public static void AddtoCart(IWebDriver driver, ISikuliSession session) 
            
        {
            string path = "C:\\Training\\CapstoneProjectClone\\Images\\Create_Your_Own.png";     // Click on the product labled Create Your Own Jewelry image (Use Sikuli).  Product Page will be displayed
            IPattern iPattern = Patterns.FromFile(path);
            session.Wait(iPattern);
            session.Click(iPattern);

        }
    }
}
