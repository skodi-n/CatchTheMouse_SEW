using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchTheMouse.Lib;

namespace CatchTheMouse.GUI
{


    public partial class CatchTheMouse : Form
    {
        Game _game = new Game(10, 10);

        public CatchTheMouse()
        {
            InitializeComponent();
            GameButton gb = new GameButton();
            gb.Width = 84;
            gb.Height = 84;
            gb.BackgroundImage = Properties.Resources.CTM;
            gb.BackgroundImageLayout = ImageLayout.Zoom;
            gb.Click += new System.EventHandler(this.GameButton_Click);
            
        }

        Image GetImageJerry()
        {
            return Properties.Resources.jerry;
        }

        Image GetImageTom() 
        { 
            
            return Properties.Resources.tom;
        
        }

        Image GetImageCTM()
        {

            return Properties.Resources.CTM;

        }
        
        Image GetImagetcj()
        {

            return Properties.Resources.tomcatchesjerry;

        }




        private void CatchTheMouse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flwCTM_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
