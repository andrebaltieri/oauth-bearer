using OAuthServer.Resources;
using OAuthServer.Utils.Settings;
using System;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace OAuthServer.Domain
{
    public class User
    {
        public User(string username, string password)
        {
            Contract.Requires<InvalidCastException>(Regex.IsMatch(username, RegexSettingsHelper.REGEX_USERNAME), AuthenticationResources.InvalidUsername);
            Contract.Requires<InvalidCastException>(Regex.IsMatch(password, RegexSettingsHelper.REGEX_PASSWORD), AuthenticationResources.InvalidPassword);
            
            this.Username = username;
            this.Password = password;
        }

        protected User() { }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
