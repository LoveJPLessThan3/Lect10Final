using System;

namespace ForTestLect10
{
    class Program
    {
        static double MyPow(double value, int degree)
        {
            double temp = value;
            while (degree > 1)
            {
                temp *= value;
                degree--;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            double value;
            int degree;
            Console.Write("Введите число");
            value = double.Parse(Console.ReadLine());
            Console.Write("Введите степень");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine(MyPow(value, degree));
        }
    }
}
