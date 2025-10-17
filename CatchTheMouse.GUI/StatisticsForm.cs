using CatchTheMouse.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheMouse.GUI
{
    public partial class StatisticsForm : Form
    {
        UserManager usermanager = new UserManager();
        CatchTheMouse _catchthemouse; 

        public StatisticsForm()
        {
            InitializeComponent();
            LoadUsers();
            _catchthemouse = new CatchTheMouse();
            _catchthemouse.StatisticsForm = this;
        }
        internal void LoadUsers()
        {
            lstUsers.Items.Clear();
            lstUsers.Items.AddRange(usermanager.GetUsers());
            

        } 

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbxFirst == null && tbxLast == null)
            {
                _catchthemouse.Show();
                this.Hide();


            }

            else
            {

                usermanager.AddUser(new User(tbxFirst.Text, tbxLast.Text, 0));
                _catchthemouse.Show();
                this.Hide();

            }

            

        }

        private void tbxFirst_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
