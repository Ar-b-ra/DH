using System;
using System.Windows.Forms;
using System.Numerics;

namespace DH
{

    //static class Data
    //{
    //  public static string Value { get; set; }
    //}

    static class Program
    {
        public static long p;
        public static long g;
        public static long A;
        public static long B;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }

        public static long PowMod(long a, long b, long c)
        {
            long res = 1;
            if (c == 1)
                return 0;            
            for (int i = 1; i <= b; i++)
            { 
            res = (res * a) % c;
            }            
            return res;
        }

        public static bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    MessageBox.Show("Число не является простым!");
                    return false;
                }                    
            return true;
        }

        public static bool Kor(long g, long p)
        {
            Double n;
            bool ret = true;            
            n = PowMod(g, p - 1, p);
            if (n != 1)
                { 
                MessageBox.Show("Число g не является первообразным корнем по модулю p!");
                ret = false;
                return ret;
                }                            
            for (long k = 2; k <= p-1; k++)
            {                
                n = PowMod(g, k, p);
                if ((n == 1) && k!=p-1)
                {                    
                    ret = false;
                    MessageBox.Show("Число g не является первообразным корнем по модулю p!");
                    break;
                }                
            }            
            return ret;
        }         
    }       
}

