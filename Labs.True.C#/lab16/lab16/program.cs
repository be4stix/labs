using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lab16
{
    class program
    {
        

        StreamWriter outlet = new StreamWriter(@"C:\Users\Сергей\Desktop\Labs.True.C#\lab16\lab16\outlet.txt");
        static void Main(string[] args)
        {
            var mc = new program();
            int init;
            int n, a, b, R;
            Console.WriteLine("Вариант инициализатора");
            init = int.Parse(Console.ReadLine());
            int[] A = new int[] { };
            if (init == 1)
            {
                mc.Formirovat1();
                string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab16\lab16\inlet.txt";

                string[] str = File.ReadAllLines(fin);
                string[] strm = str[0].Split();
                string[] strm2 = str[1].Split();

                n = int.Parse(strm[0]);
                a = int.Parse(strm[1]);
                b = int.Parse(strm[2]);
                R = int.Parse(strm[3]);
                A = new int[n];

                for (int i = 0; i < n; i++)
                {
                    A[i] = int.Parse(strm2[i]);
                }
                reshenie1();
                reshenie2();
                reshenie3();
                reshenie4(); 

            }
            else 
            {
                mc.Formirovat2();
                string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab16\lab16\inlet.txt";

                string[] str = File.ReadAllLines(fin);
                string[] strm = str[0].Split();

                n = strm.Length;
                for(int i = 0; i < n; i++)
                {
                    A[i] = int.Parse(strm[i]);
                }
                Console.WriteLine("Введите a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите b(b>a)");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите R");
                R = int.Parse(Console.ReadLine());

                reshenie1();
                reshenie2();
                reshenie3();
                reshenie4();
            }
            mc.outlet.Close();

            void reshenie1()
            {
               int max = A[0];
                int k = 0;
                for (int i = 1; i < n; i++)
                {
                    if (A[i] > max)
                    {
                        max = A[i];
                        k = i;
                    }   
                }

                int f = A[n-1];
                A[n-1] = A[k];
                A[k] = f;

                for (int i = 0; i < n; i ++)
                {
                    mc.outlet.Write(A[i].ToString() + " ");
                }
                mc.outlet.WriteLine();
            }

            void reshenie2()
            {
                List<float> vector = new List<float> { };
                for (int i =0; i < n; i++)
                {
                    if (A[i] >= a && A[i] <= b)
                    {
                        vector.Add(A[i]);
                    }
                }

            }

           void reshenie3()
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i]> R)
                    {
                        sum += A[i];
                    }
                }
                mc.outlet.WriteLine(sum.ToString());
            }

            void reshenie4()
            {
                int max = A[0];
                for (int i = 1; i < n; i++ )
                {
                    if (Math.Abs(A[i]) > Math.Abs(max))
                    {
                        max = A[i];
                    }
                }
                mc.outlet.WriteLine(max.ToString());
            }
            
        }
        public void Formirovat1()
        {
             int n, a, b, R;
             
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab16\lab16\inlet.txt";
            Random ran = new Random();
            StreamWriter inlet = new StreamWriter(fin);

            n = ran.Next(1, 10);//n случайное число от 1 до 10;
            b = ran.Next(5, 10);
            a = ran.Next(1, 5); // a от 1 до 5, b от 5 до 10 чтобы  a < b 
            R = ran.Next(-30, 30);
            int[] A = new int[n] ;

            inlet.Write(n + " ");//запись в инлет с пробелом
            inlet.Write(a + " ");
            inlet.Write(b + " ");
            inlet.Write(R + " ");
            inlet.WriteLine();//переход на новую строку


            for (int i = 0; i < n; i++) //формируем массив А и записываем в инлет
            {
                A[i] = ran.Next(-30, 30);
                inlet.Write(A[i].ToString()+ " ");
            }
            inlet.Close();
        }
        public void Formirovat2()
        {
            string fin = @"C:\Users\Сергей\Desktop\Labs.True.C#\lab16\lab16\inlet.txt";
            Random ran = new Random();
            StreamWriter inlet = new StreamWriter(fin);
            int n = ran.Next(1, 10);
            int[] A = new int[n];
            for(int i = 0; i < n; i++)
            {
                A[i] = (int)Math.Pow(2,(ran.Next(1, 5)));
                inlet.Write(A[i].ToString() + " ");
            }
            inlet.Close();
        }
    }
}
