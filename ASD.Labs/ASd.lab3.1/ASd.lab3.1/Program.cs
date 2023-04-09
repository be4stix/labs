using System;
 
namespace ASd.lab3._1
{
    class Program
    {
        static void SortArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                int c = a[i];
                a[i] = a[min];
                a[min] = c;
                //  PrintArray(a);
            }
        }
        static void PrintArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
        static void RandomArray(int[] a)
        {
         
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rand.Next(200);
        }
        static void SortedArray(int[] a)
        {
            Random rand = new Random();
            a[0] = rand.Next(20);
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + rand.Next(20);
            }
        }
        static void SortedArrayBack(int[] a)
        {
            Random rand = new Random();
            a[a.Length - 1] = 10000;
            int i = a.Length;
            for (int s = 0; s < a.Length; s++)
            {
                a[s] = i;
                i--;
            }
        }
        static void PartSortedArray(int[] a)
        {
            Random rand = new Random();

            a[0] = rand.Next(20);
            for (int i = 1; i < a.Length; i++)
            {
                if (i < 0.9 * a.Length)
                {
                    a[i] += rand.Next(10);
                }
                else
                {
                    a[i] = rand.Next(200);
                }
            }
         }
        static void HalfSorted(int[] a)
        {
            Random rand = new Random();
            int l = a.Length / 2;
            int k = 1;
            for(int i = l; i< a.Length; i++)
            {
                a[i] = k;
                k++;
            }
            int f = l;
            for(int i = 0; i< l; i++)
            {
                a[i] = f;
                f++;
            }
        }
        static void Main(string[] args)
        {
            int n = 100;

            for (int s = 0; s < 4; s++)
            {
                int[] a = new int[n];
                //RandomArray(a);
                SortedArray(a);
                //SortedArrayBack(a);
                //PartSortedArray(a);
                //HalfSorted(a);

                DateTime then = DateTime.Now;
                SortArray(a);
                DateTime now = DateTime.Now;
                Console.WriteLine(now - then);
                if (s < 3)
                {
                    n *= 10;
                }
                else
                {
                    n *= 5;
                }
            }
        }
    } 

}

 