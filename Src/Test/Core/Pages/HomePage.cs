using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace TestingMusescore.Test.Core.Pages;

public class HomePage : BasePage
{
    [FindsBy(How.XPath, "//*[@headerstate='primary']//*[text()='Log in']")]
    private IWebElement _loginButton;

    [FindsBy(How.XPath, "//*[contains(@src, 'default_avatar')]/following::*[2]")]
    private IWebElement _accountUsername;

    public void ClickOnLoginButton()
    {
        _loginButton.Click();
    }
    
    public string GetAccountUsername()
    {
        _webDriverWait.Until(ExpectedConditions.ElementToBeClickable(_accountUsername));
        return _accountUsername.Text;
    }
}