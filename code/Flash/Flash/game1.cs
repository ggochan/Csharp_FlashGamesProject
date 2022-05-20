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
    public partial class game1 : Form
    {
        int margin = 35;
        int n_Size = 30;
        int d_Size = 28;
        int z_Size = 10;

        Graphics g;
        Graphics g2;
        Pen pen;
        Brush whiteB, blackB;
        enum Stone { none,black,white};
        Stone[,] Gamepan = new Stone[31, 24];
        bool turn = false;  // false=검, true=흰
        
        public game1()
        {
            InitializeComponent();

            pen = new Pen(Color.Black);
            whiteB = new SolidBrush(Color.White); //흰
            blackB = new SolidBrush(Color.Black); //검
           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGamepan();
            
        }
    
        private void DrawGamepan()// 오목게임판
        {
            g = g1_pa1.CreateGraphics();
            g2 = g1_pa3.CreateGraphics();
            for(int i=0; i<31; i++)
            {
                g.DrawLine(pen, new Point(margin + i * n_Size, margin), new Point(margin + i * n_Size, margin + 23 * n_Size)); // 세로줄
            }
            for (int i = 0; i < 24; i++)
            {
                g.DrawLine(pen, new Point(margin,margin + i * n_Size), new Point(margin + 30 * n_Size,margin + i * n_Size)); // 가로줄
            }
            for (int i = 5; i <= 25; i += 10)
            {
                for (int j = 4; j <= 20; j += 8)
                {
                    g.FillEllipse(blackB, margin + n_Size * i - z_Size / 2, margin + n_Size * j - z_Size / 2, z_Size, z_Size); // 점
                }
            }
            g2.FillEllipse(blackB, 0, 0, 120, 120);
        }
        private void g1_btn1_Click(object sender, EventArgs e)
        {

        }

        private void g1_btn2_Click(object sender, EventArgs e)
        {
            Newgame();
        }

        private void g1_btn3_Click(object sender, EventArgs e)
        {
            rank ra = new rank();
            ra.Show();
            this.Close();
        }

        private void g1_pa1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + n_Size / 2) / n_Size;
            int y = (e.Y - margin + n_Size / 2) / n_Size;

            if(Gamepan[x,y] != Stone.none)
            {
                return;
            }
            Rectangle rect = new Rectangle(margin + n_Size * x - d_Size / 2, margin + n_Size * y - d_Size / 2, d_Size, d_Size);
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
            g1_check(x, y);
        }
        private void g1_check(int x, int y)
        {
            int cnt = 1;

            for (int i = x + 1; i <= 30; i++) //가로
            {
                if (Gamepan[i, y] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            for (int i = x - 1; i >= 0; i--)
            {
                if (Gamepan[i, y] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            if (cnt == 5)
            {
                g1_end(x, y);
                return;
            }
            
            else if(cnt >5)
            {
                MessageBox.Show("5목 초과입니다. 5목을 만들어주세요!");
            }
            cnt = 1;
            for(int i= y+1; i<=23; i++) //세로
            {
                if (Gamepan[x, i] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            for(int i=y-1; i >= 0; i--)
            {
                if (Gamepan[x, i] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            if (cnt == 5)
            {
                g1_end(x, y);
                return;
            }
            else if (cnt > 5)
            {
                MessageBox.Show("6목입니다");
            }
            cnt = 1;
            for(int i=x+1,j=y-1;i<=30 && j>=0; i++, j--)
            {
                if (Gamepan[i, j] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            for(int i=x-1,j=y+1;i>=0&&j<=23; i--,j++) // 대각선
            {
                if (Gamepan[i, j] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            if (cnt == 5)
            {
                g1_end(x, y);
                return;
            }
            else if (cnt > 5)
            {
                MessageBox.Show("6목입니다");
            }
            cnt = 1;
            for(int i=x-1,j=y-1; i>=0 &&j>=0; i--, j--)
            {
                if (Gamepan[i, j] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            for(int i=x+1,j=y+1; i<=30 && j<= 23; i++, j++)
            {
                if (Gamepan[i, j] == Gamepan[x, y])
                    cnt++;
                else
                    break;
            }
            if (cnt == 5)
            {
                g1_end(x, y);
                return;
            }
            else if (cnt > 5)
            {
                MessageBox.Show("6목입니다");
            }
        }
        private void g1_end(int x, int y)
        {
            DialogResult re = MessageBox.Show(Gamepan[x, y].ToString().ToUpper() + "이 이겼습니다! 다시 하시겠습니까?", "오목게임종료", MessageBoxButtons.YesNo);
            if(re==DialogResult.Yes)
            {
                Newgame();
            }
            else if(re == DialogResult.No)
            {
                this.Close();
            }
        }
        private void Newgame()
        {
            turn = false;
            for (int x = 0; x < 31; x++)
            {
                for (int y = 0; y < 24; y++)
                {
                    Gamepan[x, y] = Stone.none;
                }
            }
            g1_pa1.Refresh();
            DrawGamepan();
        }

        private void g1_btn5_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                DialogResult re2 = MessageBox.Show("WHITE" + "이 이겼습니다! 다시 하시겠습니까?", "오목게임종료", MessageBoxButtons.YesNo);
                if (re2 == DialogResult.Yes)
                {
                    Newgame();
                }
                else if (re2 == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (turn == true)
            {
                DialogResult re2 = MessageBox.Show("BLACK" + "이 이겼습니다! 다시 하시겠습니까?", "오목게임종료", MessageBoxButtons.YesNo);
                if (re2 == DialogResult.Yes)
                {
                    Newgame();
                }
                else if (re2 == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void g1_btn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
