
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Server;

namespace SimplePlatform.Classes
{
    internal class User
    {
        private readonly string Name;
        private readonly string? Surname;
        private readonly string Email;
        private readonly DateTime DateOfRegistration;
        private readonly string Password;
        private readonly Guid UID;

#pragma warning disable CS8618 
        public User(string name, string? surname, string email, string password, string confirmpassword)
#pragma warning restore CS8618 
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.DateOfRegistration = DateTime.Now;
            if (password.ToString() == confirmpassword.ToString()) this.Password = Crypto.HashPassword(password);
            this.UID = System.Guid.NewGuid();
        }
    }
}
