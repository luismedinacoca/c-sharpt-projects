using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace _selenium;

internal class Program
{
    private static void Main(string[] args)
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        // Create a new instance of the driver
        IWebDriver driver = new ChromeDriver();
        // And now use this to visit Google
        driver.Navigate().GoToUrl("http://www.google.com");
        //Maximize the window:
        driver.Manage().Window.Maximize();
        // Find the text input element by its name
        var query = driver.FindElement(By.Name("q"));
        // Enter something to search for
        query.SendKeys("Hello Selenium WebDriver!");
        // Submit the form based on an element in the form
        query.Submit();
        // Check the title of the page
        Console.WriteLine(driver.Title);
    }
}