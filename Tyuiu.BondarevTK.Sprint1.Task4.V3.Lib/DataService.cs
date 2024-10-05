using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BondarevTK.Sprint1.Task4.V3.Lib
{
    public class DataService : ISprint1Task4V3
    {
        public double Calculate(double x, double y)
        {
            double z = x - y;
            double m = Math.Sqrt(3 * x) / (Math.Pow(z, 2));
            return Math.Round(m, 3);
        }
    }
}
