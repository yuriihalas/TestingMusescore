using NUnit.Framework;
using TestingMusescore.Test.Core;
using TestingMusescore.Test.Core.BusinessLogic;
using TestingMusescore.Test.Core.Utils;

namespace TestingMusescore.Test.Steps;

[Binding]
public class LoginSteps
{
    private HomePageLogic _homePageLogic;
    private LoginPageLogic _loginPageLogic;

    public LoginSteps()
    {
        _homePageLogic = new HomePageLogic();
        _loginPageLogic = new LoginPageLogic();
    }

    [Given(@"User navigate to the base page")]
    public void GivenUserNavigateToTheBasePage()
    {
        WebDriverManager.GetDriver().Navigate().GoToUrl(WebConstants.BaseUrl);
    }

    [When(@"User with ""(.*)"" and ""(.*)"" authorise into account")]
    public void WhenUserWithAndAuthoriseIntoAccount(string login, string password)
    {
        _loginPageLogic.Login(login, password);
    }

    [Then(@"Account username should be ""(.*)""")]
    public void ThenAccountUsernameShouldBe(string accountUsername)
    {
        Assert.AreEqual(_homePageLogic.GetAccountUsername(), accountUsername);
    }

    [Then(@"Incorrect credentials modal contains ""(.*)""")]
    public void ThenIncorrectCredentialsModalContains(string text)
    {
        Assert.That(_loginPageLogic.GetIncorrectCredentialsModalText(), Contains.Substring(text));
    }
}