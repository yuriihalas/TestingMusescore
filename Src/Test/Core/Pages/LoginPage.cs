using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace TestingMusescore.Test.Core.Pages;

public class LoginPage : BasePage
{
    [FindsBy(How.Id, "username")]
    private IWebElement _usernameField;
    
    [FindsBy(How.Id, "password")]
    private IWebElement _passwordField;
    
    [FindsBy(How.Id, "user-login-form")]
    private IWebElement _userLoginForm;

    [FindsBy(How.XPath, "//*[@href='/user/password']/parent::span")]
    private IWebElement _incorrectCredentialsModal;

    public void FillLogin(string login)
    {
        _webDriverWait.Until(ExpectedConditions.ElementToBeClickable(_userLoginForm));
        _usernameField.SendKeys(login);
    }

    public void FillPassword(string password)
    {
        _passwordField.SendKeys(password);
    }

    public void ClickEnter()
    {
        _passwordField.SendKeys(Keys.Enter);
    }

    public string GetIncorrectCredentialsModalText()
    {
        _webDriverWait.Until(ExpectedConditions.ElementToBeClickable(_incorrectCredentialsModal));
        return _incorrectCredentialsModal.Text;
    }
}