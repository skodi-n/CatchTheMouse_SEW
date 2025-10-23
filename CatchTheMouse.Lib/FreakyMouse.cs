using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class FreakyMouse : Player, IMouse
    {
        int _counter;
        public FreakyMouse(PlayingArea playing) : base(playing)
        {
        }
        public bool IsVisible
        {
            get
            {

                return true;

            }

        }
        public override Position Move()
        {
            MouseMove freakytp = MouseMove.GetMove();

            _counter++;
            if (_counter % 5 != 0)
            {
                while (true)
                {
                    MouseMove move = MouseMove.GetMove();
                    Position position = new Position(Position.X + move.DeltaX, Position.Y + move.DeltaY);
                    if (_playingArea.IsValid(position))
                    {
                        Position.X = position.X;
                        Position.Y = position.Y;
                        return position;

                    }


                }


            }
            
            return new Position();

            


        }


    }
}
