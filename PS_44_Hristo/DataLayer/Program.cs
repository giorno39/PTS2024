using DataLayer.Database;
using DataLayer.Model;
using Microsoft.Extensions.Logging;
using Welcome.Enum;

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Names = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    Role = UsersRolesEnum.STUDENT,

                });
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.WriteLine("Username:");
                string username = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();

                Console.WriteLine($"{username} {password}");
                var current_user = context.Users.Where(x => x.Names == username).Where(x => x.Password == password).FirstOrDefault();

                if (current_user != null)
                {
                    Console.WriteLine("Valid User");
                }
                else
                {
                    Console.WriteLine("Invalid User");
                }

                Console.ReadKey();
            }
        }
    }
}
