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
    public partial class main : Form
    {   
  
        public main()
        {

            
            InitializeComponent();
          
        }

        private void game1_Click(object sender, EventArgs e)
        {
           
            game1 g1 = new game1();
            g1.ShowDialog();
            g1.Dispose();
        }

        private void game2_Click(object sender, EventArgs e)
        {
            game2 g2 = new game2();
            g2.ShowDialog();
            g2.Dispose();
        }

        private void game3_Click(object sender, EventArgs e)
        {
            game3 g3 = new game3();
            g3.ShowDialog();
            g3.Dispose();
        }

        private void rankbtn_Click(object sender, EventArgs e)
        {
            rank rk = new rank();
            rk.ShowDialog();
            rk.Dispose();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.ShowDialog();
            us.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reuser re = new reuser();
            re.ShowDialog();
            re.Dispose();
        }
    }
}
