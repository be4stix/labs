using System;
using System.IO;

namespace построениеКлассаВектор_задача01
{
    public class ФормировательФайлаДанныхЗадачи01
    {
        Random ran = new Random();
        public int[] A = new int[] { };
        public int n,a,b,R;

        public ФормировательФайлаДанныхЗадачи01(int вариантТестФайла)
        {
            string fin = @"C:\Users\Сергей\Desktop\МОП\16 Класс Вектор\построениеКлассаВектор_задача01\построениеКлассаВектор_задача01\inlet.txt";

            StreamWriter inlet = new StreamWriter(fin);

             n = ran.Next(1, 10);//n случайное число от 1 до 10;
             b = ran.Next(5, 10);
             a = ran.Next(1, 5); // a от 1 до 5, b от 5 до 10 чтобы  a < b 
             R = ran.Next(-30, 30); 

            inlet.Write(n + " ");//запись в инлет с пробелом
            inlet.Write(a + " ");
            inlet.Write(b + " ");
            inlet.Write(R + " ");
            inlet.WriteLine();//переход на новую строку


            for (int i = 0; i < n; i ++) //формируем массив А и записываем в инлет
            {
                A[i] = ran.Next(-30, 30);
                inlet.Write(A[i]);
            }
            inlet.Close();
        }
    }
}
