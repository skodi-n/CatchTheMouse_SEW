﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse.Lib
{
    public class PlayingArea
    {
        internal int Width { get; }

        internal int Height { get; }

        internal PlayingArea (int width, int height)
        {
            Width = width;
            Height = height;
        }

        internal bool IsValid(Position position)
        {
            if (position.X < 0 || position.X >= Width || position.Y < 0 || position.Y >= Height) 
            { 
            
                return false;
            
            }

            return true;

           
        }
    }
}
