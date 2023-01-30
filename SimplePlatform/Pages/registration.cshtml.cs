using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_Dec2022.Pages
{
    [IgnoreAntiforgeryToken]
    public class Registration : PageModel
    {

        public void OnGet()
        {

        }
//        public void OnPost(string username, string usersurname, string usernickname,
//                           string usertargets, string dateofbirth, string usersex,
//                           string useremail, string password, string confirmpassword)
//        {
//            void recordtoDatabase()
//            {
                
//                UbasicInfo _ubasicinfo = new();
//                UauthInfo _auth = new();


//                using (CurrentDbContext db = new CurrentDbContext())
//                {

//                    if (password.ToString() == confirmpassword.ToString())
//                        {
//                            char[] _musthavesymbols = new char[] { '!', '@', '#', '$', '%', '&', '*', '(', ')', '_', '+', '=' };
//                            char[] _pwd = password.ToString().ToCharArray();
//                            if (password.ToString().Contains(' '))
//                            {
//                                //error
//                            }
//                            else
//                            {
//                                foreach (var _passwordsymbols in _pwd)
//                                {

//                                    foreach (var _musthavesymbol in _musthavesymbols)
//                                    {
//                                        if (_passwordsymbols != _musthavesymbol)
//                                        {
//                                            //error
//                                        }
//                                        else
//                                        {
//                                            //error
//                                        }
//                                    }
//                                }

//                            }
//                        _ubasicinfo.Name = username.ToString();
//                        _ubasicinfo.Surname = usersurname.ToString();
//                        _ubasicinfo.Searchtargets = usertargets.ToString();
//                        _ubasicinfo.Dateofbirth = dateofbirth.ToString();
//                        _ubasicinfo.Gender = usersex.ToString();
//                        _ubasicinfo.Accountcreatedinfo = DateTime.Now.ToString();
//                        _ubasicinfo.Uid = Convert.ToString(new Random().Next(2, 100000000));
//                        _ubasicinfo.PhoneNumber = " ";


//                    }
//#nullable disable
//                        foreach (var _usernickname in db.UbasicInfos)
//                        {
//                            if (_usernickname.Nickname.ToString() == usernickname.ToString())
//                            {
//                                Redirect("/Pages.Pages_login");
//                            }
//                            else
//                            {
//                                _ubasicinfo.Nickname = usernickname.ToString();
//                            }
//                        }
//#nullable enable
//                        foreach (var _email in db.UbasicInfos)
//                        {
//                            if (_email.Email.ToString() == useremail.ToString())
//                            {
//                                Redirect("/Pages.Pages_login");
//                            }
//                            else
//                            {
//                                foreach (var _mailpostfix in CheckTheData.CheckTheMailFormat)
//                                {
//                                    if (useremail.ToString().Contains(_mailpostfix.ToString()))
//                                    {
//                                        _ubasicinfo.Email = useremail.ToString();
//                                    }
//                                    else
//                                    {

//                                    }
//                            }
//                        }
//                    }

//                    db.Add(_ubasicinfo);
//                    db.SaveChanges();
//                }
//                using (CurrentDbContext dsb = new CurrentDbContext())
//                {
//                    _auth.Login = _ubasicinfo.Email.ToString();
//                    _auth.Password = password.ToString();
//                    dsb.UauthInfos.Add(_auth);
//                    dsb.SaveChanges();
//                }


//            }

//            recordtoDatabase();
        //}

    }
}




