using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    internal class MouseMove
    {
        private static Random _random = new Random();
        private static MouseMove[] _allMoves;

        internal int DeltaX { get; }
        internal int DeltaY { get; }

        public static MouseMove()
        {
            _allMoves = new MouseMove[]
            {
                new MouseMove(-1, -1), 
                new MouseMove(-1,  0), 
                new MouseMove(-1,  1), 
                new MouseMove( 0, -1), 
                new MouseMove( 0,  1), 
                new MouseMove( 1, -1), 
                new MouseMove( 1,  0), 
                new MouseMove( 1,  1),  
            };
        }

        internal MouseMove(int deltaX, int deltaY)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        internal static MouseMove GetMove()
        {
            return _allMoves[_random.Next(_allMoves.Length)];
        }
    }
}
