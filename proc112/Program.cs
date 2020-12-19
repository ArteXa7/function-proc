using System;

namespace proc112
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }
    class Proc16
    {
        static void task16()
        {
            int a = 0;
            int b = 0;
            Console.WriteLine(Sign(a) + Sign(b));
        }

        static int Sign(double x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
                return 1;
        }
    }
    class Proc17
    {
        static void task17()
        {
            double a = 12.5;
            double b = 15.5;
            double c = 10.2;
            Console.WriteLine(RootsCount(a, b, c));
        }

        static double RootsCount(double a, double b, double c)
        {
            double d = (b * b) - 4 * a * c;
            return d;
        }
    }
    class Proc18
    {
        static void task18()
        {
            double r = 70.2;
            Console.WriteLine(CircleS(r));
        }
        static double CircleS(double r)
        {
            double s = 3.14 * (r * r);
            return s;
        }
    }
    class Proc19
    {
        static void task19()
        {
            double r1 = 5.5;
            double r2 = 2.2;

            for (int i = 0; i < 3; i++)
                Console.WriteLine(RingS(r1, r2));
        }
        static double RingS(double r1, double r2)
        {
            return 3.14 * (r1 + r2) * (r1 - r2);
        }
    }
    class Proc20
    {
        static void task20()
        {
            double a = 2.4;
            double h = 2;

            for (int i = 0; i < 3; i++)
                Console.WriteLine(TriangleP(a, h));
        }
        static double TriangleP(double a, double h)
        {
            double b;
            return b = Math.Sqrt((a / 2) * (a / 2) + h * h);
        }
    }
    class Proc21
    {
        static void task21()
        {
            int a = 10;
            int b = 5;
            int c = 1;
            Console.WriteLine(SumRange(a, b));
        }
        static int SumRange(int a, int b)
        {
            int sum = 0;
            if (a > b)
                return 0;
            for (int i = b; i < a; i++)
                sum += i;
            return sum;

        }
    }
    class Proc22
    {
        static void task22()
        {
            int a = 5;
            int b = 31;
            int k = 0;
            Console.WriteLine(Calc(a, b));

        }
        static double Calc(int a, int b)
        {
            int n = 2;
            int k = 0;
            if (n == 1)
            {
                k = a + b;
            }
            else if (n == 2)
            {
                k = a - b;
            }
            else if (n == 3)
            {
                k = a * b;
            }
            else if (n == 4)
            {
                k = a / b;
            }
            return k;
        }
    }
    class Proc23
    {
        static void task23()
        {
            int x = 34;
            int y = -23;
            int k = 0;
            Console.WriteLine(k);
        }
        static int Quarter(int x, int y)
        {
            int k = 0;
            if (x > 0 && y > 0)
            {
                k = 1;
            }
            else if (x < 0 && y > 0)
            {
                k = 2;
            }
            else if (x < 0 && y < 0)
            {
                k = 3;
            }
            else if (x > 0 && y < 0)
            {
                k = 4;
            }
        }
    }
    class Proc24
    {
        static void task24()
        {
            int k = 92;
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                if (Even(k))
                {
                    count++;
                }
                Console.WriteLine(count);
            }
            static bool Even(bool k)
            {
                bool Even(int k)
                {
                    return k % 2 == 0;
                }

            }
        }
    }
    class Proc25
    {
        static void task25()
        {
            int k = 100;
            Console.WriteLine(IsPower5);
        }
        static bool IsPower5(bool k)
        {
            bool IsPower5(int k)
            {
                for (int i = 1; i * i <= k; i++) ;
                if (i * i == k)
                    return true;
                else return false;
            }
        }
    }
    class Proc26
    {
        static void task26()
        {
            bool IsPower5(int K);

        }
        static bool IsPower5(float k)
        {

        }
    }
    class Proc27
    {

    }
    class Proc28
    {

    }
    class Proc29
    {

    }
    class Proc30
    {

    }
    class Proc31
    {

    }
    class Proc32
    {

    }
    class Proc33
    {

    }
    class Proc34
    {

    }
    class Proc35
    {

    }
    class Proc1
    {
        static void task1()
        {
            double a = double.Parse(Console.ReadLine());
            double b;
            PowerA3(a, out b);
        }
        static void PowerA3(in double A, out double B)
        {
            B = Math.Pow(A, 3);
        }
    }
    class Proc2
    {
        static void task2()
        {
            for (int i = 0; i < 6; i++)
            {
                double a = double.Parse(Console.ReadLine());
                double b, c, d;
                PowerA234(a, out b, out c, out d);
            }
        }
        static void PowerA234(in double A, out double B, out double C, out double D)
        {
            B = Math.Pow(A, 2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
        }
    }
    class Proc3
    {
        static void task3()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double GMean, AMean;
            Mean(a, b, out AMean, out GMean);
            Console.WriteLine(AMean + " " + GMean);
            Mean(a, c, out AMean, out GMean);
            Console.WriteLine(AMean + " " + GMean);
            Mean(a, d, out AMean, out GMean);
            Console.WriteLine(AMean + " " + GMean);
        }
        static void Mean(in double x, in double y, out double AMean, out double GMean)
        {
            AMean = (x + y) / 2;
            GMean = Math.Sqrt(x * y);
        }
    }
    class Proc4
    {
        static void task4()
        {
            for (int i = 0; i < 4; i++)
            {
                double a = double.Parse(Console.ReadLine());
                double P, S;
                TrianglePS(a, out P, out S);
                Console.WriteLine(P + " " + S);
            }
        }
        static void TrianglePS(in double a, out double P, out double S)
        {
            P = 3 * a;
            S = Math.Pow(a, 2) * Math.Sqrt(3 / 4);
        }
    }
    class Proc5
    {
        static void task5()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            RectPS(x1, y1, x2, y2, out double P, out double S);
            Console.ReadKey();
        }
        static void RectPS(int x1, int y1, int x2, int y2, out double P, out double S)
        {
            P = 0;
            S = 0;
            P = 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
            S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
        }
    }
    class Proc6
    {
        static void task6()
        {
            for (int i = 0; i < 5; i++)
            {
                int k;
                Console.Write("k: ");
                k = int.Parse(Console.ReadLine());
                DigitCountSum(k, out int c, out int s);
                Console.WriteLine("c: " + c);
                Console.WriteLine("s: " + s);
            }
            Console.ReadKey();
        }
        public static void DigitCountSum(int k, out int c, out int s)
        {
            c = 0;
            s = 0;
            while (k != 0)
            {
                s += k % 10;
                ++c;
                k /= 10;
            }
        }
    }
    class Proc7
    {
        static void task7()
        {
            for (int i = 0; i <= 5; i++)
            {
                int k = int.Parse(Console.ReadLine());
                InvertDigits(ref k);
                Console.WriteLine(k);

            }
        }
        static void InvertDigits(ref int k)
        {
            int t = k;
            k = 0;
            while (t != 0)
            {
                k = k * 10 + (t % 10);
                t /= 10;

            }
        }
    }
    class Proc8
    {

    }
    class Proc9
    {

    }
    class Proc10
    {

    }
    class Proc11
    {

    }
    class Proc12
    {

    }
    class Proc13
    {

    }
    class Proc14
    {

    }
    class Proc15
    {

    }
}
