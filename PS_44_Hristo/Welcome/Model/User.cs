using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Enum;

namespace Welcome.Model
{
    public class User
    {
        public string Names { get; set; }
        public string Password { get; set; }
        public UsersRolesEnum Role { get; set; }

    }
}
