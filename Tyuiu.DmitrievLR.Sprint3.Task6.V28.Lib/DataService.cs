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
                int divisorsCount = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorsCount++;
                        if (divisorsCount >= 7)
                        {
                            break;
                        }
                    }
                }
                if (divisorsCount < 7)
                {
                    count++;
                }

            }
                return count;
        }
    }
}
