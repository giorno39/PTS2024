using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Enum;
using Welcome.Model;

namespace WelcomeExtended.Data
{
    internal class UserData
    {
        private List<User> _users;

        public int _nextId;

        public UserData() {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user) {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void DeleteUser(User user) {
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password) {
            foreach (var user in _users)
            {
                if (user.Names == name && user.Password == password) {
                    return true;
                }
            }

            return false;
        }


        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Password == password)
                .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                      where user.Names == name && user.Password == password
                      select user.Id;
            return ret != null ? true : false;
        }

        public User? GetUser(string name, string password)
        {
            User curr_user = _users.Where(x => x.Names == name && x.Password == password)
                .FirstOrDefault();
            if (curr_user == null)
            {
                throw new Exception("User not found");
            }
            return curr_user;
        }

        public void SetActive(string name, DateTime date) {
            User curr_user = _users.Where(x => x.Names == name).
                FirstOrDefault();
            if(curr_user != null)
            {
                curr_user.Expires = date;
            }
        }

        public void AssignUserRole(string name, UsersRolesEnum role) {
            User curr_user = _users.Where(x => x.Names == name)
                    .FirstOrDefault();

            if (curr_user != null)
            {
                curr_user.Role = role;
            }

        }

    }
    }



