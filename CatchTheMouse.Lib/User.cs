using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class User
    {
        public string FirstName { get; }

        public string LastName { get; }

        public DateTime LastGamesTime { get; }

        public int HighScore { get; }


        public User(string firstName, string lastName, int highscore)
        {
            FirstName = firstName;
            LastName = lastName;
            HighScore = highscore;
        }

        public User(string firstName, string lastName, DateTime lastgamesTime, int highscore)
        {
            FirstName = firstName;
            LastName = lastName;
            LastGamesTime = lastgamesTime;
            HighScore = highscore;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({HighScore})";
        }


    }
}
