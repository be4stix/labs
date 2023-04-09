using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Рекурсия_10
{
    class Program
    {

        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\Рекурсия-10\Рекурсия-10\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\Рекурсия-10\Рекурсия-10\outlet.txt";

            string[] str = File.ReadAllLines(fin);
            string[] strm = new string[] { };
            char[] bukvi = new char[] { };

            string el = str[str.Length-1];
            char[] ele = el.ToCharArray();  //ОПРЕДЕЛЯЕМ ЭЛЕМЕНТ, КОТОРЫЙ НУЖНО ПОСЧИТАТЬ
            char elem = ele[0];


            int i = 0, kolvo = 0, k = 0;
            func();
            File.WriteAllText(fout, kolvo.ToString());

            void func()
            {
                strm = str[i].Split();

                if (strm.Length < 2)
                {
                    File.WriteAllText(fout, "-1");
                    Environment.Exit(0);
                }

                bukvi = strm[strm.Length - 2].ToCharArray();

                func2();

                strm = new string[] { };
                i++;
                if (i < str.Length-1)
                {
                    func();
                }


            }

            void func2()
            {
                if (bukvi[k] == elem)
                {
                    kolvo++;
                }

                
                if (k < bukvi.Count()-1)
                {
                    k++;
                    
                    func2();
                }
                k = 0;
                bukvi = new char[] { };
            }






        }

    }
}
 