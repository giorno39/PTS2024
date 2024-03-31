using System;
using Welcome.Model;
using Welcome.Enum;
using Welcome.View;
using Welcome.ViewModel;


namespace Welcome
{
    internal class Program
    {

        static void Main(string[] args)
        {
            User user = new User();
            user.Names = "Giorno";
            user.Role = Enum.UsersRolesEnum.ADMIN;
            user.Password = "dummy.txt";

           UserViewModel userViewModel = new UserViewModel(user);
           UserView viewWindow = new UserView(userViewModel);

            viewWindow.Display();






        }
    }
}
