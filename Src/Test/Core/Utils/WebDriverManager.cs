using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingMusescore.Test.Core.Utils;

public static class WebDriverManager
{
    private static readonly string PathToDriver =
        SourceUtils.GetSourceDir() + "Src/Test/Resources/Chromedriver/chromedriver.exe";

    private static readonly int ImplicitWaitTimeoutSec = 3;

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

    private static void CreateChromeWebDriver()
    {
        ChromeOptions chromeOptions = new ChromeOptions();
        _currentDriver = new ChromeDriver();
        //_currentDriver.Url = WebConstants.BaseUrl;
        //_currentDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ImplicitWaitTimeoutSec);
        //_currentDriver.Manage().Window.Maximize();
    }
}