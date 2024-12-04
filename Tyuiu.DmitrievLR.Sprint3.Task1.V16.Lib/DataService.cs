using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double dd = 1;
            for (int i = startValue; i <= 5; i++)
            {
                dd += ( Math.Pow(value, 2) * Math.Sin(i) ) + 1;
            }
            
            
            return Math.Round(dd,3);
        }
    }
}
