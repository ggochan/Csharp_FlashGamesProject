using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Flash
{   
    public partial class User : Form
    {
        MySqlConnection conn;
        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            string strConn = string.Format(@"Server=localhost; Database=flash; Uid=root;Pwd=1234;");
           conn = new MySqlConnection(strConn);
            try
            {
                conn.Open();
                MessageBox.Show("성공");
            }
            catch
            {
                conn.Close();
                MessageBox.Show("실패");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into usernick(nick) values( '" + nickbox.Text + "'",conn);
            String insertsql = "insert into usernick(nick) values( '" + nickbox.Text + "'";
        }

        
    }
}
