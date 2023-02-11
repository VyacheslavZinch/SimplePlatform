using SimplePlatform.Classes;
using System.Text;
using System.Text.Json;

namespace Server.Database
{
    public class DatabaseMethods
    {
        public static string GetInfoAboutUser(string UID)
        {
            StringBuilder sb = new StringBuilder();
            using (GeneralDbContext db = new GeneralDbContext())
            {
                User usr = new User();
                usr.UID = UID;
#pragma warning disable CS8601 // Possible null reference assignment.


                usr.Name = (from p in db.UserInfos
                            where p.Uid == UID
                            select p.Name).ToString();

                usr.Surname = (from p in db.UserInfos
                            where p.Uid == UID
                            select p.Surname).ToString();

                usr.Email = (from p in db.UserInfos
                            where p.Uid == UID
                            select p.Email).ToString();

                usr.DateOfRegistration = (from p in db.UserInfos
                            where p.Uid == UID
                            select p.Dateofregistration).ToString();

                usr.Password = String.Empty;

#pragma warning restore CS8601 // Possible null reference assignment.

            }

            string result = JsonSerializer.Serialize(sb);
            return result;
        }
    }
}
