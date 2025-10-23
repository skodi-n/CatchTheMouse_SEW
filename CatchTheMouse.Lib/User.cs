using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class User
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime LastGamesTime { get; private set; }

        public int HighScore 
        { 
            get;

            private set;
            
        
        }


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

        public int SetNewScore(int updatedScore)
        {
            if (updatedScore > HighScore)
            {
                HighScore = updatedScore;
            }
            LastGamesTime = DateTime.Now;
            return HighScore;

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({HighScore})";
        }


    }
}
