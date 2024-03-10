using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        UserViewModel _mUserView;

        public UserView(UserViewModel userView) {
            _mUserView = userView;    
        }

        public void Display() {
            Console.WriteLine("Welcome");
            Console.WriteLine("User: {0}", _mUserView.Name);
            Console.WriteLine("Role: {0}", _mUserView.Role);
      
        }

        public void DisplayError() {
            throw new Exception("Some error accured");
        }

    }
}
