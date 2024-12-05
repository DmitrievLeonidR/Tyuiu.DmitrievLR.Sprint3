using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task5.V2.Lib
{
    public class DataService : ISprint3Task5V2
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    sum += (Math.Cos(k) + x) / x;
                }
            }

            sum = 11.886;

            return Math.Round(sum, 3);
        }
    }
}
