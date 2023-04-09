using System;
using System.IO;
namespace Матрицы_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\Матрицы-8+\Матрицы-8\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\Матрицы-8+\Матрицы-8\outlet.txt";
            string[] str = File.ReadAllLines(fin);

            string[] dannie = str[0].Split();

            int kolX = int.Parse(dannie[0]);
            int kolY = int.Parse(dannie[1]);
            int b = int.Parse(dannie[2]);

            int summ = 0;
            int kolvo = 0;

            for (int i = 1; i < kolY; i++)
            {
                string[] strm = str[i].Split();

                for (int k = 0; k < kolX; k++)
                {
                    summ += int.Parse(strm[k]);
                    
                }

                if (summ/kolX < b)
                {
                    kolvo++;
                }
                
                summ = 0;
                for (int f=1; f < kolX; f++)
                {
                    strm[f] = "";
                }
            }

            File.WriteAllText(fout, kolvo.ToString());

        }
    }
}
