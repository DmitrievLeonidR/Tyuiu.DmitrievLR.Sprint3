using Tyuiu.DmitrievLR.Sprint3.Task5.V2.Lib;
namespace Tyuiu.DmitrievLR.Sprint3.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                            *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите 1 начальное значение: ");
            int startValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите 1 конечное значение: ");
            int stopValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите 2 начальное значение: ");
            int startValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите 2 конечное значение: ");
            int stopValue2 = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetSumSumSeries(x,startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}