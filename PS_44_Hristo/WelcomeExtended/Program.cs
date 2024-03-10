using WelcomeExtended.Others;
using Welcome.Model;
using Welcome.Enum;
using Welcome.ViewModel;
using Welcome.View;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User();
                {
                    user.Names = "John Smith";
                    user.Password = "password";
                    user.Role = UsersRolesEnum.STUDENT;
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);

                view.Display();

                view.DisplayError();
            }
            catch (Exception ex)
            {
                var log = new ActionOnError(Delegates.Log);
                log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case");
            }
        }
    }
}
