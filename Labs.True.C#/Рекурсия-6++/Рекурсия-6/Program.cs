using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\Рекурсия-6+\Рекурсия-6\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\Рекурсия-6+\Рекурсия-6\outlet.txt";
            string[] text = File.ReadAllLines(fin);
            double a = double.Parse(text[0]);
            double b = double.Parse(text[1]);
            double tochnost = double.Parse(text[2]);
            double k = Rec(a,b,tochnost,NP(a,b));
            
            File.WriteAllText(fout, k.ToString());
             
        }

        static double Fun(double x)
        {
            x = x* x - System.Math.Sin(5 * x);
            return x;
        }

         static double Fun1(double x)
        {
            x = 2 * x - 5 * System.Math.Cos(5 * x);
            return x;
        }

        static double Fun2(double x)
        {
            x = 2 + 25 * System.Math.Sin(5 * x);
            return x;
        }

        static double NP(double a, double b)
        {
            if (Fun(a) * Fun2(a) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static double SK(double a, double b, double tochnost, double x)
        {
            if (System.Math.Abs(Fun(x)) > tochnost)
            {
                return SK(a, b, tochnost, x - Fun(x) / Fun1(x));
            }
            else
            {
                return x;
            }
        }

        static double Rec(double a, double b, double tochnost, double x)
        {
            if (x-SK(a,b,tochnost,x) > tochnost)
            {
                return SK(a, b, tochnost, x - Fun(x) / Fun1(x));
            }
            else
            {
                return x;
            }
        }

    }
}
