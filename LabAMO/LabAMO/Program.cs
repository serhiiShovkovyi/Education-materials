﻿using System;
namespace LabAmo
{
    public delegate double Function(double x);
    class Program
    {
        public static double SimpsonMethod(Function f, double b, double a, int n)
        {
            double sum = 0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
                sum += (f(a) + f(b) + 4 * (f(a + h) + f(a + (i - 1) * h)) + 2 * (f(a + 2 * h) + f(a + (i - 2) * h))) * h / 3;
            return sum;
        }

        public static double SimpsonMethod_For_x(double x)
        {
            return Math.Pow(x,2);
        }

        static void Main(string[] args)
        {
            Function sim = new Function(SimpsonMethod_For_x);
            double a, b;
            int n;
            Console.Write("Нижняя граница интегрирования. a=");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Верхняя граница интегрирования. b=");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Количество отрезков. n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("Интеграл = {0}", SimpsonMethod(sim, b, a, n));
            Console.ReadKey();
        }
    }

}
