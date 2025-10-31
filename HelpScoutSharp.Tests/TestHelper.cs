namespace HelpScoutSharp.Tests;

/// <summary>
/// If running in Visual Studio, you may needto restart Visual Studio after setting environment variables
/// </summary>
public class TestHelper
{
    public static string ApplicationId = GetEnvVar("HELP_SCOUT_SHARP_APP_ID");

    public static string ApplicationSecret = GetEnvVar("HELP_SCOUT_SHARP_APP_SECRET");

    private static string GetEnvVar(string name)
    {
        return Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.User) ??
               Environment.GetEnvironmentVariable(name) ??
               throw new InvalidOperationException($"Environment variable '{name}' is not set. Please set it before running the tests.");

    }
}
