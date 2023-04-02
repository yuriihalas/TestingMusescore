using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingMusescore.Test.Core.Utils;

public static class WebDriverManager
{
    private static IWebDriver _currentDriver;

    public static IWebDriver GetDriver()
    {
        if (_currentDriver == null)
        {
            CreateChromeWebDriver();
            return _currentDriver;
        }

        return _currentDriver;
    }

    public static void CloseDriver()
    {
        _currentDriver.Quit();
        _currentDriver = null;
    }

    private static void CreateChromeWebDriver()
    {
        ChromeOptions chromeOptions = new ChromeOptions();
        chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
        _currentDriver = new ChromeDriver(WebConstants.PathToDriver, chromeOptions);
        _currentDriver.Url = WebConstants.BaseUrl;
        _currentDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(WebConstants.ImplicitWaitTimeoutSec));
        _currentDriver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(WebConstants.ImplicitWaitTimeoutSec));
        _currentDriver.Manage().Window.Maximize();
    }
}