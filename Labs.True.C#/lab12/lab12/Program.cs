using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Строки_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab12\lab12\inlet.txt";
            string fout = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab12\lab12\outlet.txt";
            StreamWriter output = new StreamWriter(fout);
            //StreamReader input = new StreamReader(fin);
            string[] str = File.ReadAllLines(fin);
            int kol_students = str.Length / 2,kol =0;
            string[] surname = new string[kol_students];
            int[] mark = new int[] { };
            Student[] stud = new Student[kol_students];
            int s=0;

            for (int i = 0; i < str.Length; i++)
            {
                string[] strm = str[i].Split();
                if (i % 2==0)
                {
                    surname[s] = strm[0];
                    s++;
                } 
                else
                {
                    for(int k = 4; k > strm.Length; k--)
                    {
                        mark[k] = int.Parse(strm[k]);
                    }
                    stud[s].Results = mark;
                    s++;
                }
                
            }

            for (int i = 0; i < stud.Length; i++)  //для подсчёта кол-ва сдавших сессию
            {
                kol += !stud[i].Bolshe7 ? 1 : 0;
            }

            
            foreach (Student student in stud)
            {
                output.WriteLine(student.Surname + student.sredniy);
            }

            output.Write(kol);

            output.Close();
        }
        struct Student
        {
            string FIO;
            int[] marks;
            public string Surname
            {
                get
                {
                    return FIO;
                }
                set
                {
                    FIO = value;
                }
            }
            public int[] Results
            {
                set
                {
                    marks = new int[5];
                    marks = value;
                }
            }
            public bool Bolshe7
            {
                get
                {
                    bool have = false;
                    foreach (int mark in marks)
                    {
                        have = have || mark >= 7;
                    }
                    return have;
                }
            }
            public int sredniy
            {

                get
                {
                    int sum = 0;
                    foreach (int mark in marks)
                    {
                        sum += mark;   
                    }
                    return sum / 5;
                }
            }
        }
    }
}

