using TestingMusescore.Test.Core.Utils;

namespace TestingMusescore.Test.Core;

public static class WebConstants
{
    public static readonly string PathToDriver =
        SourceUtils.GetSourceDir() + "/Src/Test/Resources/Chromedriver/chromedriver.exe";

    public static readonly string BaseUrl = "https://musescore.com";
    public static readonly int ImplicitWaitTimeoutSec = 5;
    public static readonly TimeSpan ExplicitWaitTime = TimeSpan.FromSeconds(90);
}