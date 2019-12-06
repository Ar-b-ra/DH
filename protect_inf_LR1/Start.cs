using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace DH
{
    public partial class Start : Form
    {
        public static long p;
        public static long g;
        public Start()
        {
            InitializeComponent();
            
        }
        public void buttonEncrypt_Click_2(object sender, EventArgs e)
        {
                                  
            if (Program.IsTheNumberSimple(Convert.ToInt64(p_Public.Text)) && Program.IsTheNumberSimple(Convert.ToInt64(g_Public.Text)) && Program.Kor(Convert.ToInt64(g_Public.Text), Convert.ToInt64(p_Public.Text)))                                         
            {                
                Alice A = new Alice();
                Bob B = new Bob();
                A.Owner = this;
                B.Owner = this;
                Program.p = Convert.ToInt64(p_Public.Text);
                Program.g = Convert.ToInt64(g_Public.Text);
                A.Show();
                B.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
