using TestingMusescore.Test.Core.Pages;

namespace TestingMusescore.Test.Core.BusinessLogic;

public class LoginPageLogic
{
    private LoginPage _loginPage;
    private HomePage _homePage;

    public LoginPageLogic()
    {
        _homePage = new HomePage();
        _loginPage = new LoginPage();
    }

    public void Login(string username, string password)
    {
        _homePage.ClickOnLoginButton();
        _loginPage.FillLogin(username);
        _loginPage.FillPassword(password);
        _loginPage.ClickEnter();
    }

    public string GetIncorrectCredentialsModalText()
    {
        return _loginPage.GetIncorrectCredentialsModalText();
    }
}