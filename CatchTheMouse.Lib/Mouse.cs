using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class Mouse : Player
    {
        public Mouse(PlayingArea playingArea) : base(playingArea)
        {
        }

        public override Position Move()
        {
            while (true)
            {
                MouseMove move = MouseMove.GetMove();
                Position position = new Position(Position.X + move.DeltaX, Position.Y + move.DeltaY);
                if (_playingArea.IsValid(position))
                {

                    return position;

                }


            }


        }
      



    }
}
