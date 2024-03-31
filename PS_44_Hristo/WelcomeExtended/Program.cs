using WelcomeExtended.Others;
using Welcome.Model;
using Welcome.Enum;
using Welcome.ViewModel;
using Welcome.View;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserData userData = new UserData();
                User studentUser = new User()
                {
                    Names = "student",
                    Password = "123",
                    Role = UsersRolesEnum.STUDENT
                };

                userData.AddUser(studentUser);

                User secondStudent = new User()
                {
                    Names = "student2",
                    Password = "123",
                    Role = UsersRolesEnum.STUDENT
                };

                userData.AddUser(secondStudent);

                User teacher = new User()
                {
                    Names = "Teacher",
                    Password = "1234",
                    Role = UsersRolesEnum.PROFESSOR,
                };

                userData.AddUser(teacher);

                User admin = new User()
                {
                    Names = "Admin",
                    Password = "12345",
                    Role = UsersRolesEnum.ADMIN,
                };

                userData.AddUser(admin);

                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();

                userData.ValidateCredentials(name, password);
                User selectedUser = userData.GetUser(name, password);

                Console.WriteLine(selectedUser.ToString(true));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        }
    }

