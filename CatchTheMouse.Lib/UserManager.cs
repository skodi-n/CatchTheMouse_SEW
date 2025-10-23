using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class UserManager
    {
        List<User> _users = new List<User>();

        public UserManager()
        {
            AddUser(new User("Manfred", "Theiler", DateTime.Now, 789));
            AddUser(new User("Sebastian", "Köck", DateTime.Now, 857));
            AddUser(new User("Franz", "Lackinger", DateTime.Now, 906));
            AddUser(new User("Elisabeth", "Schaludek", DateTime.Now, 856));
            AddUser(new User("Jakob", "Scheithe", DateTime.Now, 988));
        }

        public void AddUser(User user)
        {
            if (!_users.Contains(user)) 
            {

                _users.Add(user);

            }
            

        }

        public User[] GetUsers()
        {

            return _users.ToArray();

        }

    }
}
