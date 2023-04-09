using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Текстовые_Файлы_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\Текстовые Файлы-11++\Текстовые Файлы-11\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\Текстовые Файлы-11++\Текстовые Файлы-11\outlet.txt";
            string[] str = File.ReadAllLines(fin);
            string el = str[0].ToString();

            int kolvo = 0;

            for (int i = 1; i< str.Length;i++)
            {
                string[] strm = str[i].Split();
                for (int k = 0; k < strm.Length; k++)
                {
                    string[] slovo = strm[k].Split();
                    if (slovo[0].Contains(el))
                    {
                        kolvo++;
                    }
                
                }
            }
            File.WriteAllText( fout,kolvo.ToString());

        }
    }
}
