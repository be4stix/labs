using System;
using System.IO;

namespace построениеКлассаВектор_задача01
{
    
    public class Вектор
    {
        
        public void reshenie1()
        {
            int max = A[0],k;
            for (int i = 1; i < n; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    k = i;
                }
            }

            int f = A[n - 1];
            A[n - 1] = A[k];
            A[k] = f;

            return A;
        }
    }
}
