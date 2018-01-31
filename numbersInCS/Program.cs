using System;

namespace numbersInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            int g = 5;
            int h = 4;
            int i = 2;
            int j = g + h * i;
            int k = (g + h) * i;

            Console.WriteLine(j);
            Console.WriteLine(k);

            int l = (g + h) - 6 * i + (12 * 4) / 3 + 12;
            Console.WriteLine(l);

            int m = 7;
            int n = 4;
            int o = 3;
            int p = (m + n) / o;
            int q = (m + n) % o;

            //Console.WriteLine(p);
            //Console.WriteLine(q);
            Console.WriteLine($"qoutient: {p}");
            Console.WriteLine($"remainder: {q}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}.");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double r = 5;
            double s = 4;
            double t = 2;
            double u = (r + s) / t;

            Console.WriteLine(u);

            double da = 19;
            double db = 23;
            double dc = 8;
            double dd = (da + db) / dc;

            Console.WriteLine(dd);

            double maxD = double.MaxValue;
            double minD = double.MinValue;

            Console.WriteLine($"The range of double is {minD} to {maxD}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            //Challenge

            double AA = 42.24;
            double BB = 23.1;
            double CC = 647;
            double DD = (AA + BB) * CC / 7;

            Console.WriteLine(DD);

        }
    }
}
