using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;

namespace Tyuiu.SinitsinDV.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            double res = 100;
            string[] lines = File.ReadAllLines(path);

            double positiveSum = 0;
            double negativeSum = 0;

            foreach (string line in lines)
            {
                
                if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    if (number % 1 == 0)
                    {
                        if (number > 0)
                            positiveSum += number;
                        else
                            negativeSum += number;

                    }
                   
                }
                
            }
            

            return res;
        }
    }
}