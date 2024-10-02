using Tyuiu.BondarevTK.Sprint1.Task3.V3.Lib;
namespace Tyuiu.BondarevTK.Sprint1.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double length = 9;
            double height= 5;
            double width = 7.5;
            Console.WriteLine("Высота прямоугольника = " + height);
            Console.WriteLine("Ширина прямоугольника = " + width);
            Console.WriteLine("Длина прямоугольника = " + length);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь прямоугольника = " + ds.ParallelepipedVolume(length,width,height));

            Console.ReadKey();

        }
    }
}
