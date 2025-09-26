using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    abstract public class Player
    {
        static Random _random = new Random();

        public Position Position { get; }

        protected PlayingArea _playingArea; 

        protected Player(PlayingArea playingArea)
        {
            
            _playingArea = playingArea;
            Position = new Position();
            DoMove();

        }

        public void Move(Position position)
        {
            {

                Position.X = position.X;
                Position.Y = position.Y;
            
            }

        }

        virtual public Position Move()
        {

            DoMove();
            return Position;

        }

        private Position DoMove()
        {
            Move(new Position(_random.Next(_playingArea.Width), _random.Next(_playingArea.Height)));
            return Position;
        }
    }
}
