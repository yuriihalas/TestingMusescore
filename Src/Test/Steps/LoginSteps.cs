using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TestingMusescore.Test.Core;
using log4net;
using log4net.Config;
using TestingMusescore.Test.Core.Utils;

namespace TestingMusescore.Test.Steps;

[Binding]
public class LoginSteps
{
    public static readonly ILog Log = LogManager.GetLogger(typeof(LoginSteps));

    [When(@"User with ""(.*)"" and ""(.*)"" authorise into account")]
    public void WhenUserWithAndAuthoriseIntoAccount(string login, string password)
    {
        WebDriverManager.GetDriver().Navigate().GoToUrl(WebConstants.BaseUrl);
        Console.WriteLine("fdsfsdf");
        Console.WriteLine("f");

        Assert.True(true);
    }

    [Then(@"User should be navigated to the home page")]
    public void ThenUserShouldBeNavigatedToTheHomePage()
    {
        //ScenarioContext.StepIsPending();
    }
}