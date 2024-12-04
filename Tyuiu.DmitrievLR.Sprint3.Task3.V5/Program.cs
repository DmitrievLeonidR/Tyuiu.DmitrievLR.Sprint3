using Tyuiu.DmitrievLR.Sprint3.Task3.V5.Lib;
namespace Tyuiu.DmitrievLR.Sprint3.Task3.V5
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("введите текст: ");
            string startValue = Convert.ToString(Console.ReadLine());

            char replaceable, replacement;
            
            Console.WriteLine("введите какую букву заменить: ");
            replaceable = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("введите на что заменить: ");
            replacement = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.ReplaceCharInString(startValue, replaceable, replacement);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}