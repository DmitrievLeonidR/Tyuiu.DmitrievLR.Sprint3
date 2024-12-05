using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task5.V2.Lib
{
    public class DataService : ISprint3Task5V2
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double dd = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                

                for (int k = startValue2; k <= stopValue2; k++)
                {
                    dd += ( Math.Cos(k) + x ) / x;
                }


                return Math.Round(dd, 3);
            }


            return Math.Round(dd, 3);
        }
    }
}
