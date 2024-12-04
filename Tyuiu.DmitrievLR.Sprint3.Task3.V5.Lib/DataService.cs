using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DmitrievLR.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string newString = "";

            foreach (char character in value)
            {
                if (character == replaceable)
                {
                    newString += $"{replacement}";
                }
                else
                {
                    newString += character;
                }
            }

            return newString;
        }
    }
}
