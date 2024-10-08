﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BondarevTK.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double p = (Math.Sin(Math.Pow(x, 2)) + y) / (y + 1);
            double o = (x * y - 12) / (34 + Math.Pow(x, 2));
            return Math.Round(p - o,3);
        }
    }
}
