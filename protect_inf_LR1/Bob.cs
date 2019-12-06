using System;
using System.Numerics;
using System.Windows.Forms;

namespace DH
{    
    public partial class Bob : Form
    {       
        private static long b;
        public long B;
        public long p;
        public long g;
        public long KB;
        public Bob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.A > -1)
            {
                b_Private.Text = Convert.ToString(b);
                B_Public.Text = Convert.ToString(B);
                Bob_From_Alice.Text = Convert.ToString(Program.A);                
                KB_Private.Text = Convert.ToString(Program.PowMod(Convert.ToInt64(Program.A), b, Program.p));
            }
        }            
        private void Prepare_Click(object sender, EventArgs e)
        {
             if (Int64.TryParse(b_Private.Text, out long n))
            {
                b = n;                
                B = Program.PowMod(Program.g, b, Program.p);
                B_Public.Text = Convert.ToString(B);
                Program.B = (long)B;
            }
        }
    }
}
