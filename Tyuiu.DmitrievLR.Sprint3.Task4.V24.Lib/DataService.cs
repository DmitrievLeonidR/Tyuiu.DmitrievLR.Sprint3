using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task4.V24.Lib
{
    public class DataService : ISprint3Task4V24
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double p = 1;
            for (x = startValue; x <= stopValue; x++)
            {
                // Проверка на x = 0
                if (x == 0)
                {
                    Console.WriteLine("x = 0, цикл прерван.");
                    break;
                }


                double y = Math.Sin(x) / x + 2;

                p *= y;

            }

            return p;
        }
    }
}
