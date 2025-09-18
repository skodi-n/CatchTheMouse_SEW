using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    internal class MouseMove
    {
        static Random _random = new Random();
        static MouseMove[] _allmoves;

        internal int DeltaX { get; }

        internal int DeltaY { get; }

        public static MouseMove()
        {



        }

        MouseMove(int deltaX, int deltaY)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }
    }
}
