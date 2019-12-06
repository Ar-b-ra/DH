using System;
using System.Windows.Forms;
using System.Numerics;

namespace DH
{
    public partial class Alice : Form
    {
        private static long a;
        public long A;       
        public long p;
        public long g;
        public long KA;
        public Alice()
        {
            InitializeComponent();
        }
        private void Send_And_Take_Click(object sender, EventArgs e)
        {
            Bob Bob = new Bob();
            if (Program.B > -1)
            {
                a_Private.Text = Convert.ToString(a);
                A_Public.Text = Convert.ToString(A);
                Alice_From_Bob.Text = Convert.ToString(Program.B);
                KA_Private.Text = Convert.ToString(Program.PowMod(Convert.ToInt64(Program.B), a, Program.p));                    
            }            
        }
        private void Prepare_Click(object sender, EventArgs e)
        {
            if (Int64.TryParse(a_Private.Text, out long n))
            {
                a = n;
                A = Program.PowMod(Program.g, a, Program.p);
                A_Public.Text = Convert.ToString(A);
                Program.A = (long)A;
            }
        }
    }
}
