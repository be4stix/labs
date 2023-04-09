namespace И_циклы
{
    class Program
    {
       public double  koren, result = 0, x,a,b,tochnost;
        static void Main(string[] args)
        {
            var mc = new Program();

            System.Console.WriteLine("VVedite a: ");
            mc.a = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Vvedite b: ");
            mc.b = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Vvedite tochnost: ");
            mc.tochnost = double.Parse(System.Console.ReadLine());

            mc.koren = mc.Reshenie(mc.a, mc.b, mc.tochnost);

            System.Console.WriteLine($"Koren: {mc.koren}");
            System.Console.ReadLine();
        }
        static double F1(double x)
        {
            x = System.Math.Cos(2 / x) - 2 * System.Math.Sin(1 / x) + 1 / x;
            return x;
        }
        static double F2(double x)
        {
            x = 1 / (x * x) * (2 *System.Math.Cos(1 / x) + 2 * System.Math.Sin(2 / x) - 1);
            return x;
        }
        static double Np(double a, double b)
        {
            if (F1(a) * F2(a) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
       double Reshenie(double a, double b, double tochnost)
        {
            x = Np(a, b);
            while (System.Math.Abs(F1(x)) > tochnost)
            {
                return   x - F1(x) / F2(Np(a, b));
            }
            return x;   
        }
    }
}
