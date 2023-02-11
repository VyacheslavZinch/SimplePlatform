
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Server;

namespace SimplePlatform.Classes
{
    internal class User
    {
        public string Name;
        public string? Surname;
        public string Email;
        public string DateOfRegistration;
        public string Password;
        public string UID;

    }
}
