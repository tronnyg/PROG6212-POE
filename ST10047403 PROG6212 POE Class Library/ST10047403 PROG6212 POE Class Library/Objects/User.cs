using System;

namespace ST10047403_PROG6212_POE_Class_Library.Objects
{
    public class User
    {
        // ==== ATTRIBUTES === //
        private string username;
        private string password;
        // ================== //

        // ==== CONSTRUCTOR === //
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        // ================== //

        // ==== GETTERS AND SETTERS === //
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        // ================== //
    }
}
