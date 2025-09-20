using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class MouseMove
    {
        private static Random _random = new Random();
        private static MouseMove[] _allMoves;

        internal int DeltaX { get; }
        internal int DeltaY { get; }

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
