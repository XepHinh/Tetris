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
        private void btn_Tutorial_MouseHover(object sender, EventArgs e)
        {
            btn_Tutorial.Image = Properties.Resources.tutorial_hover;
        }
        private void btn_About_MouseHover(object sender, EventArgs e)
        {
            btn_About.Image = Properties.Resources.about_hover;
        }
        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.Image = Properties.Resources.exit;
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            btn_Start.Image = Properties.Resources.start_leave;
        }                
        private void btn_Tutorial_MouseLeave(object sender, EventArgs e)
        {
            btn_Tutorial.Image = Properties.Resources.tutorial_leave;
        }
        private void btn_About_MouseLeave(object sender, EventArgs e)
        {
            btn_About.Image = Properties.Resources.about_leave;
        }
        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.Image = Properties.Resources.exit_leave;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Tetris newTetris = new Tetris();
            newTetris.ShowDialog();
        }
        private void btn_Tutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAIDA HƯỚNG DẪN SỬ DỤNG\n" +
                            "@ Sử dụng phím mũi tên trái, phải để di chuyển vị trí khối sang 2 bên\n" +
                            "@ Mũi tên lên để thay đổi hướng của khối Tetromino\n" +
                            "@ Mũi tên xuống để khối Tetromino rơi nhanh hơn");
        }
        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEAM PHÁT TRIỂN ỨNG DỤNG\n" +
                "@Trần Minh Tâm_4501104206\n" +
                "@Nguyễn Văn Châu_\n" +
                "@Thiều Quan Bảo TÍn_");
        }     
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
