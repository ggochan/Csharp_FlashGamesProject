using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash
{
    public partial class rank : Form
    {
        board_g1 b_g1 = new board_g1();
        board_g2 b_g2 = new board_g2();
        board_g3 b_g3 = new board_g3();
        public rank()
        {
            InitializeComponent();

        }
        private void r_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void r_game1_MouseClick(object sender, MouseEventArgs e)
        {
            r_game1.BackColor = Color.FromArgb(32, 115, 232);
            r_game2.BackColor = Color.FromArgb(255, 255, 255);
            r_game3.BackColor = Color.FromArgb(255, 255, 255);
            r_pa2.Controls.Clear();
            r_pa2.Controls.Add(b_g1);
        }


        private void r_game2_MouseClick(object sender, MouseEventArgs e)
        {
            r_game1.BackColor = Color.FromArgb(255, 255, 255);
            r_game2.BackColor = Color.FromArgb(32, 115, 232);
            r_game3.BackColor = Color.FromArgb(255, 255, 255);

            r_pa2.Controls.Clear();
            r_pa2.Controls.Add(b_g2);
        }

        private void r_game3_Click(object sender, EventArgs e)
        {
            r_game1.BackColor = Color.FromArgb(255, 255, 255);
            r_game2.BackColor = Color.FromArgb(255, 255, 255);
            r_game3.BackColor = Color.FromArgb(32, 115, 232);
            r_pa2.Controls.Clear();
            r_pa2.Controls.Add(b_g3);
        }
    }
}
