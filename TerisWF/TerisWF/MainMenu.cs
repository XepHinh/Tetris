using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerisWF
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void btn_Start_MouseHover(object sender, EventArgs e)
        {
            btn_Start.Image = Properties.Resources.start_hover;
        }

        private void btn_Option_MouseHover(object sender, EventArgs e)
        {
            btn_Option.Image = Properties.Resources.option_hover;
        }

        private void btn_Tutorial_MouseHover(object sender, EventArgs e)
        {
            btn_Tutorial.Image = Properties.Resources.tutorial_hover;
        }

        private void btn_About_MouseHover(object sender, EventArgs e)
        {
            btn_About.Image = Properties.Resources.about_hover;
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            btn_Start.Image = Properties.Resources.start_leave;
        }

        private void btn_Option_MouseLeave(object sender, EventArgs e)
        {
            btn_Option.Image = Properties.Resources.option_leave;
        }

        private void btn_Tutorial_MouseLeave(object sender, EventArgs e)
        {
            btn_Tutorial.Image = Properties.Resources.tutorial_leave;
        }

        private void btn_About_MouseLeave(object sender, EventArgs e)
        {
            btn_About.Image = Properties.Resources.about_leave;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Tetris newTetris = new Tetris();
            newTetris.ShowDialog();
        }

        private void btn_Option_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Tutorial_Click(object sender, EventArgs e)
        {

        }

        private void btn_About_Click(object sender, EventArgs e)
        {

        }
    }
}
