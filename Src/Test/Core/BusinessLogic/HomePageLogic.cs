using TestingMusescore.Test.Core.Pages;

namespace TestingMusescore.Test.Core.BusinessLogic;

public class HomePageLogic
{
    private HomePage _homePage;

    public HomePageLogic()
    {
        _homePage = new HomePage();
    }

    public string GetAccountUsername()
    {
        return _homePage.GetAccountUsername();
    }
}