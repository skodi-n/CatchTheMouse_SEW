using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    abstract internal class Player
    {
        static Random _random = new Random();

        public Position Position { get; }

        protected PlayingArea _playingArea; 

        protected Player(PlayingArea playingArea)
        {

            _playingArea = playingArea;

        }

        public void Move(Position position)
        {
            if (!_playingArea.IsValid(position)) 
            {

                Position.X = position.X;
                Position.Y = position.Y;
            
            }

        }

        virtual public Position Move()
        {
            Position.X = _random.Next(0, _playingArea.Width - 1);
            Position.Y = _random.Next(0, _playingArea.Height - 1);
            return Position;
            

        }
    }
}
