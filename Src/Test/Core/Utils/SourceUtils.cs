namespace TestingMusescore.Test.Core.Utils;

public static class SourceUtils
{
    public static string GetSourceDir()
    {
        var projectDirectory = Directory.GetCurrentDirectory();
        while (projectDirectory != null && !File.Exists(Path.Combine(projectDirectory, "TestingMusescore.csproj")))
            projectDirectory = Directory.GetParent(projectDirectory)?.FullName;

        return projectDirectory ?? throw new InvalidOperationException();
    }
}