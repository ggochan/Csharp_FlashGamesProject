using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash
{
    public enum Kkey
    {
        Up, Down, Left, Right
    };
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static int Level { get; set; }
        public static int Next { get; set; }
        public static int Cnt { get; set; }
        public static bool GameOver { get; set; }
        public static Kkey kkey { get; set; }
       
        public Settings()
        {   
            Width = 16;
            Height = 16;
            Speed = 16;
            Score = 0;
            Points = 100;
            Level = 1;
            Next = 300;
            Cnt = 0;
            GameOver = false;
            kkey = Kkey.Down;
        }
    }
}
