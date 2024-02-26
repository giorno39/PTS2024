using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    internal class UserViewModel
    {
        private User _mUser;

        public UserViewModel(User user) { 
            _mUser = user;
        }

        public string Name {
            get { return _mUser.Names; }
            set { _mUser.Names = value; } 
        }

        public string Password
        {
            get { return _mUser.Password; }
            set { _mUser.Password = value; }
        }

        public UsersRolesEnum Role
        {
            get { return _mUser.Role; }
            set { _mUser.Role = value; }
        }

    }
}
