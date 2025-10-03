using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class FreakyMouse : IMouse
    {
        PlayingArea _playingArea;

        public FreakyMouse(PlayingArea playingArea)
        {
            _playingArea = playingArea;
        }
        public bool IsVisible { get; }

        public Position Position { get; }
        public Position Move()
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


    }
}
