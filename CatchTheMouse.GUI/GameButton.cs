using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheMouse.GUI
{
    public class GameButton : Button
    {
        public int X { set; get; }
        public int Y { set; get; }

        public GameButton(int x, int y)
        {
            X = x;
            Y = y;

        }


    }
}
