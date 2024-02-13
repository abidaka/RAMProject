using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V119.Network;

namespace NewProject
{
    public class Tests
    {
        private IWebDriver driver;
         
        public Tests()
        { }

        public Tests(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp] 
        public void Setup()
        {
           if (driver == null)

                driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://20.193.140.27:4040/home");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.XPath("//li[4]/a")).Click();
            driver.FindElement(By.XPath(".btnRAMlight")).Click();
            driver.FindElement(By.XPath("//input[@id=\'InputEmail\']")).Click();
            driver.FindElement(By.XPath("//input[@id=\'InputEmail\']")).SendKeys("ramadmin@gmail.com");
            driver.FindElement(By.XPath("//input[@id=\'InputPassword\']")).Click();
            driver.FindElement(By.XPath("//input[@id=\'InputPassword\']")).SendKeys("19891181Aa*");
            driver.FindElement(By.XPath("//input[@id=\'Remember\']")).Click();
            driver.SwitchTo().Frame(0);
            driver.FindElement(By.XPath("//span[@id=\'recaptcha-anchor\']/div")).Click();
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.CssSelector(".my-3")).Click();
            driver.FindElement(By.XPath("//span[contains(.,\'Programs\')]")).Click();
            driver.FindElement(By.XPath("//a[@id=\'userDropdown\']/div/img")).Click();
            driver.FindElement(By.XPath("//p[contains(.,\' Logout\')]")).Click();
            driver.Close();
            Assert.Pass();
        }
    }
}