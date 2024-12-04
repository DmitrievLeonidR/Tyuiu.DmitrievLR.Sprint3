using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double dd = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                dd += Math.Pow( ( 1 / Math.Sin(k) ) ,2);
            }


            return Math.Round(dd, 3);


        }
    }
}
