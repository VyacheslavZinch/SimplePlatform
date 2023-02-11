using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimplePlatform.Database;

namespace WebApplication_Dec2022.Pages
{
    [IgnoreAntiforgeryToken]
    public class Registration : PageModel
    {

        public void OnGet()
        {

        }
        public void OnPost(string username, string usersurname, string dateofbirth,
                          string useremail, string password, string confirmpassword)
        {



        }
    }
}





