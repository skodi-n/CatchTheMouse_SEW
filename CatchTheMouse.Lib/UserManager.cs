using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class UserManager
    {
        List<User> _users = new List<User>(5);

        public UserManager()
        {
            
        }

        public void AddUser(User user)
        {

            _users.Add(user);

        }

        public User[] GetUsers()
        {

            return _users.ToArray();

        }

    }
}
