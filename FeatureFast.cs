using System;

namespace ForTestLect10
{
    class Program
    {
        static double FeatureFast(double  x, int n)
        {
            var result = 1.0;
            while (n > 0)
            {
                if ((n & 1) == 0)
                {
                    x *= x;
                    n >>= 1;
                }
                else
                {
                    result *= x;
                    --n;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            double value;
            int degree;
            value = double.Parse(Console.ReadLine());
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine(FeatureFast(value, degree));
        }
    }
}
