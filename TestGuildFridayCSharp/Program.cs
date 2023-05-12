using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace TestGuildFridayCSharp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //!Make sure to add the path to where you are extracting the chromedriver.exe:

        IWebDriver driver = new ChromeDriver(); //<-Add your path

        driver.Navigate().GoToUrl("https://testguild.com/HpSupport.html");

        //IWebElement myField = driver.FindElement(By.Id("tools"));

        driver.FindElement(By.LinkText("QTP 11 Support Matrix with Patch Updates")).SendKeys(Keys.Enter);



    }
}

