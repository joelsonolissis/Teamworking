using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamworking
{
    public partial class telaCarregar : Form
    {
        public telaCarregar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
       private void verificar()
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                login a = new login();
                a.Show();
                this.Hide();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            verificar();
        }
    }
}
