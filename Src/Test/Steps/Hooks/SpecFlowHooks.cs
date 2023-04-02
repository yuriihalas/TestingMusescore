using TestingMusescore.Test.Core.Utils;

namespace TestingMusescore.Test.Steps.Hooks;

[Binding]
internal static class SpecFlowHooks
{
    [After]
    internal static void StopWebDriver()
    {
        WebDriverManager.CloseDriver();
    }
}