using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingMusescore.Test.Core.Utils;

namespace TestingMusescore.Test.Core.Pages;

public abstract class BasePage
{
    protected IWebDriver _webDriver;
    protected WebDriverWait _webDriverWait;

    public BasePage()
    {
        _webDriver = WebDriverManager.GetDriver();
        _webDriverWait = new WebDriverWait(_webDriver, WebConstants.ExplicitWaitTime);
        PageFactory.InitElements(_webDriver, this);
    }
}