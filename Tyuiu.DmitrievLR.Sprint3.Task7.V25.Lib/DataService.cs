using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            Func<double, double> f = x => Math.Cos(x) + 4 * x / 2 - Math.Sin(x) * 3 * x;

            double step = 1;
            double[] values = new double[(int)((stopValue - startValue) / step) + 1];

            int i = 0;
            for (double x = startValue; x <= stopValue; x += step)
            {
                // Check for division by zero
                if (x == 0)
                {
                    values[i] = 1;
                }
                else
                {
                    values[i] = Math.Round(f(x), 2);
                }
                i++;
            }
             
            return values;
        }
    }
}
