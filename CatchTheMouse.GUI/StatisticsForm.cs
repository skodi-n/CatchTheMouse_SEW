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
        CatchTheMouse _catchthemouse = new CatchTheMouse();

        public StatisticsForm()
        {
            InitializeComponent();
            LoadUsers();
        }
        public void LoadUsers()
        {

            lstUsers.Items.AddRange(usermanager.GetUsers());

        } 

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _catchthemouse.Show();
            this.Hide();

        }
    }
}
