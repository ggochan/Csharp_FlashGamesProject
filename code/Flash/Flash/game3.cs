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
    public partial class game3 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public game3()
        {
           
            InitializeComponent();
            new Settings();
            //게임시작
            GameOverTimer.Tick += UpdateScreen;
            GameOverTimer.Start();
            StartGame();
               
        }
        private void StartGame()
        {
            endla.Visible = false;
            g3_btn1.Enabled = false;
            g3_btn2.Enabled = false;
            //세팅
            new Settings(); 
            //사용자 정의
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);
            Settings.Speed = 16;
            Settings.Score = 0;
            Settings.Points = 100;
            Settings.Level = 1;
            Settings.Next = 300;
            Settings.Cnt = 0;
            g3_total.Text = Settings.Score.ToString();
            g3_total.Text = Settings.Score.ToString();
            g3_count.Text = Settings.Cnt.ToString();
            g3_lv.Text = Settings.Level.ToString();
            g3_next.Text = Settings.Next.ToString();
            GameOverTimer.Interval = 1000 / Settings.Speed;
            GenerateFood();
        }
        private void GenerateFood()
        {
            int maxXPos = g3_pa1.Size.Width / Settings.Width;
            int maxYPos = g3_pa1.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            //스타트게임
            if (Settings.GameOver)
            {
                //엔터
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.kkey != Kkey.Left)
                    Settings.kkey = Kkey.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.kkey != Kkey.Right)
                    Settings.kkey = Kkey.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.kkey != Kkey.Down)
                    Settings.kkey = Kkey.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.kkey != Kkey.Up)
                    Settings.kkey = Kkey.Down;

                MovePlayer();
            }
            g3_pa1.Invalidate();

        }
        private void g3_pa1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //머리 몸통구분
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.Green;    //Rest of body

                    //뱀
                    canvas.FillRectangle(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));
                    //음식
                    canvas.FillRectangle(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
          
        }
        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //머리
                if (i == 0)
                {
                    switch (Settings.kkey)
                    {
                        case Kkey.Right:
                            Snake[i].X++;
                            break;
                        case Kkey.Left:
                            Snake[i].X--;
                            break;
                        case Kkey.Up:
                            Snake[i].Y--;
                            break;
                        case Kkey.Down:
                            Snake[i].Y++;
                            break;
                    }


                    //맥시멈사이즈
                    int maxXPos = g3_pa1.Size.Width / Settings.Width;
                    int maxYPos = g3_pa1.Size.Height / Settings.Height;

                    //나갔을때
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //몸과 몸이 닿았을때
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //닿았을 때
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {   
                        Eat();
                    }

                }
                else
                {
                    //몸
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        private void Eat()
        {
            //닿았을때
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //점수 증가
            Settings.Score += Settings.Points;
            Settings.Cnt += 1;
            if (Settings.Score >= Settings.Next)
            {
                Settings.Speed += 10;
                Settings.Level += 1;
                Settings.Next += 300;
                GameOverTimer.Interval = 1000 / Settings.Speed;
            }
            g3_total.Text = Settings.Score.ToString();
            g3_count.Text = Settings.Cnt.ToString();
            g3_lv.Text = Settings.Level.ToString();
            g3_next.Text = Settings.Next.ToString();
            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
            endla.Visible = true;
        }
        private void g3_btn1_Click(object sender, EventArgs e)
        {
            rank ra = new rank();
            ra.Show();
            this.Close();
        }

        private void g3_btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void game3_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void game3_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
       
       
    }
}
