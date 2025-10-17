using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class Game
    {
        User user;
        const int SCORE_MAX = 1000;
        int _moves;
        internal DateTime StartTime { get; } = DateTime.Now;

        public int Score
        {
            get
            {

                return SCORE_MAX - _moves * 10 - Convert.ToInt32((DateTime.Now - StartTime).TotalSeconds);

            }
        }

        public IMouse Mouse { get; }

        public Player Cat { get; }

        public bool IsGameOver
        {
            get
            {
                if (Mouse.Position.X == Cat.Position.X && Mouse.Position.Y == Cat.Position.Y)
                {

                    return true;

                }

                return false;
            }

        }

        public Game(int width, int height, int moves)
        {
            PlayingArea playingarea = new PlayingArea(width, height);
            Cat = new Cat(playingarea);
            Mouse = new Mouse(playingarea);
            _moves = moves;
            
        }

        public void Play(Position catpositiion)
        {
            Mouse.Move();
            Cat.Move(catpositiion);
        }



    }
}
