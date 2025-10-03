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
        const int WIDTH = 10;
        const int HEIGHT = 10;

        Game _game = new Game(WIDTH, HEIGHT, 7);
        Button[,] _buttons = new Button[WIDTH, HEIGHT];

        public CatchTheMouse()
        {
            InitializeComponent();
            GameOver();
            CreateButtons();
        }
        
        void CreateButtons()
        {
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    GameButton gb = new GameButton(i, j);
                    gb.Width = 84;
                    gb.Height = 84;

                    if (_game.Mouse.Position.X == i && _game.Mouse.Position.Y == j)
                    {

                        gb.BackgroundImage = GetImageJerry();

                    }

                    else if (_game.Cat.Position.X == i && _game.Cat.Position.Y == j)
                    {

                        gb.BackgroundImage = GetImageTom();

                    }

                    else
                    {

                        gb.BackgroundImage = GetImageCTM();

                    }
                    gb.BackgroundImageLayout = ImageLayout.Zoom;
                    gb.Click += new System.EventHandler(this.GameButton_Click);
                    flwCTM.Controls.Add(gb);
                    _buttons[i, j] = gb;
                }
                flwCTM.SetFlowBreak(_buttons[i, _buttons.GetLength(1) - 1], true);
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
        { 
                _buttons[_game.Mouse.Position.X, _game.Mouse.Position.Y].BackgroundImage = GetImageCTM();
                _game.Mouse.Move();
                _buttons[_game.Mouse.Position.X, _game.Mouse.Position.Y].BackgroundImage = GetImageJerry();
                // optional Prüfung ob Spiel zu Ende ist



                GameButton button = (GameButton)sender;

                _buttons[_game.Cat.Position.X, _game.Cat.Position.Y].BackgroundImage = GetImageCTM();
                _game.Cat.Move(new Position(button.X, button.Y));
                if (_game.IsGameOver)
                {

                    _buttons[_game.Mouse.Position.X, _game.Mouse.Position.Y].BackgroundImage = GetImagetcj();
                    GameOver();

                }

                else
                {
                    _buttons[_game.Cat.Position.X, _game.Cat.Position.Y].BackgroundImage = GetImageTom();


                }



                // Bewegen der Katze
                // Prüfung ob Spiel zu Ende ist
                // ggf. Position der Maus anzeigen

        }



        

        void GameOver()
        {
            if (_game.IsGameOver)
            {
                MessageBox.Show("GEWONNEN");
                this.Close();

            }
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
