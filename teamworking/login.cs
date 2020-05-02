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
namespace teamworking
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text=="")
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=teamworking;pwd=''");
                try
                {
                    conexao.Open();
                }catch(System.Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                if (conexao.State == ConnectionState.Open)
                {
                    MySqlCommand sql = new MySqlCommand("SELECT from usuarios email='" + textBox1.Text + "' and senha='"+textBox2.Text+"'");
                    sql.ExecuteNonQuery();
                }
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
