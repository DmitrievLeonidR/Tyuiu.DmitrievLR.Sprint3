using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                // Iterate through potential divisors
                for (int j = 1; j < 7; j++)
                {
                    // Check if 'j' is a divisor of 'i'
                    if (i % j == 0)
                    {
                        // Increment the counter if it is
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
