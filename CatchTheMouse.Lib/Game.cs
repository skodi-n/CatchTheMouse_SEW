using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class Game
    {


        public Player Mouse { get; }

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

        public Game(int width, int height)
        {
            PlayingArea playingarea = new PlayingArea(width, height);
            Cat = new Cat(playingarea);
            Mouse = new Mouse(playingarea);
        }
        


    }
}
