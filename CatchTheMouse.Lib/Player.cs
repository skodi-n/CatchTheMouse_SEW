using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    abstract internal class Player
    {
        static Random _random;

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

                new Position(position.X, position.Y);
            
            }

        }

        virtual public Position Move()
        {

            return null;

        }
    }
}
