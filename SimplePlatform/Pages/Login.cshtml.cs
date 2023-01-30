using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_Dec2022.Pages
{
    [IgnoreAntiforgeryToken]
    public class Login1Model : PageModel
    {
        public void OnGet()
        {
            
        }
        public void OnPost(string username, string password) 
        {

      /*
      //      using (CurrentDbContext db = new CurrentDbContext())
      //      {
      //          var _userUID =  from p in db.UbasicInfos
      //                          join p1 in db.UauthInfos on p.Email equals p1.Login
      //                          select p.Uid;

      //          foreach (var _data in db.UauthInfos)
      //          {
      //              if ((username.ToString() == _data.Login.ToString())
      //                  &&(password.ToString()==_data.Password.ToString()))
      //              {
						//var result = HashCode.Combine(_userUID, _data.Login).ToString();
						//Response.Redirect($"/user/{_userUID}"); ;                    
      //              }
      //              else
      //              {
      //                  Response.Redirect("/registration");
      //              }

                }
            }
      */
       
        }
        
    }
}
