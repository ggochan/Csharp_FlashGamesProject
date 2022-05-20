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
   
    public partial class game2 : Form
    {
        int margin = 20;
        int n_Size = 90; // 네모사이즈
        int d_Size = 88; // 돌사이즈
        int z_Size = 15; // 점사이즈

        Graphics g;
        Graphics g2;
        Pen pen;
        Brush whiteB, blackB;
        enum Stone { none, black, white };
        Stone[,] Gamepan = new Stone[9,9];
        bool turn = false;  // false=검, true=흰

        public game2()
        {    
         
            InitializeComponent();
            g2_count1.BackColor = Color.Transparent;
            g2_count1.Parent = pictureBox1;

            pen = new Pen(Color.Black);
            whiteB = new SolidBrush(Color.White); //흰
            blackB = new SolidBrush(Color.Black); //검
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            O_DrawGamepan();
        }
        private void O_DrawGamepan()
        {
            g = g2_pa1.CreateGraphics();
            g2 = g2_pa2.CreateGraphics();
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(pen, new Point(margin + i * n_Size, margin), new Point(margin + i * n_Size, margin + 8 * n_Size)); // 세로줄
            }
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(pen, new Point(margin, margin + i * n_Size), new Point(margin + 8 * n_Size, margin + i * n_Size)); // 가로줄
            }
            for (int i = 2; i <= 6; i += 4)
            {
                for (int j = 2; j <= 6; j += 4)
                {
                    g.FillEllipse(blackB, margin + n_Size * i - z_Size / 2, margin + n_Size * j - z_Size / 2, z_Size, z_Size); // 점
                }
            }
            g2.FillEllipse(blackB, 0, 0, 120, 120);
        }
        private void O_Newgame()
        {
            turn = false;
            for(int x=0; x<9; x++)
            {
                for(int y=0; y<9; y++)
                {
                    Gamepan[x, y] = Stone.none;
                }
            }
            g2_pa1.Refresh();
            O_DrawGamepan();
        }
        private void g2_btn1_Click(object sender, EventArgs e)
        {

        }

        private void g2_btn2_Click(object sender, EventArgs e)
        {
            O_Newgame();
        }

        private void g2_btn3_Click(object sender, EventArgs e)
        {
            rank ra = new rank();
            ra.Show();
            this.Close();
        }

        private void g2_pa1_MouseDown(object sender, MouseEventArgs e)
        { int x = (e.X - margin + n_Size/2 ) /n_Size;
           int y = (e.Y - margin + n_Size /2) /n_Size;

            if(Gamepan[x, y] != Stone.none)
            {
                return;
            }
            Rectangle rect = new Rectangle(margin + n_Size * x  , margin + n_Size * y  , d_Size, d_Size);
            if(turn == false)
            {
                g.FillEllipse(blackB, rect);
                turn = true;
                Gamepan[x, y] = Stone.black;
                g2.FillEllipse(whiteB, 0, 0, 120, 120);
            }
            else if(turn ==true)
            {
                g.FillEllipse(whiteB, rect);
                turn = false;
                Gamepan[x, y] = Stone.white;
                g2.FillEllipse(blackB, 0, 0, 120, 120);
            }

        }

        private void g2_btn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
