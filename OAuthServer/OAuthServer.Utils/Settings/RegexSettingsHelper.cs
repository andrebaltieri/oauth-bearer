namespace OAuthServer.Utils.Settings
{
    public static class RegexSettingsHelper
    {
        public const string REGEX_USERNAME = "^[a-z0-9_-]{3,16}$";
        public const string REGEX_PASSWORD = "^[a-z0-9_-]{6,18}$";
    }
}
