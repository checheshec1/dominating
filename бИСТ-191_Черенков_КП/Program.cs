using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бИСТ_191_Черенков_КП
{
    class Sravnenie
    {
        public static bool sr(KSA A, KSA B)
        {
            if (A.z <= B.z)
            {
                if (A.g >= B.g)
                {
                    if (A.s <= B.s)
                    {
                        if (A.u >= B.u)
                        {
                            if (A.l <= B.l)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    class KSA
    {
        public double z;
        public int g, s, u, l;
        public KSA(double x, int q, int y, int r, int p)
        {
            z = x;
            g = q;
            s = y;
            u = r;
            l = p;
        }
        public static void Pareto(int n, KSA[] Array, ref int[] mas)
        {
            int i = 0, j = 1;
            int N = n;
            int M = N - 1;
            Boolean flag = true;
            for(int o = 0; o < N; o++)
            {
                mas[o] = 1;
            }
            do
            {
                if (Sravnenie.sr(Array[j], Array[i]))
                {
                    mas[i] = 0;
                    if (j < M)
                    {
                        j = j + 1;
                    }
                    else
                    {
                        if (i < M - 1)
                        {
                            i = i + 1;
                            j = i + 1;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
                else
                {
                    if(Sravnenie.sr(Array[i], Array[j]))
                    {
                        mas[j] = 0;
                        if (i < M - 1)
                        {
                            i = i + 1;
                            j = i + 1;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        if (j < M)
                        {
                            j = j + 1;
                        }
                        else
                        {
                            if (i < M - 1)
                            {
                                i = i + 1;
                                j = i + 1;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                    }
                }
            }
            while (flag);
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
