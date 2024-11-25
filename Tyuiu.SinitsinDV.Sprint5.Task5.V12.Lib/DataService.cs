using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;

namespace Tyuiu.SinitsinDV.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            // Считываем весь текст файла и разделяем по пробелам
            string fileContent = File.ReadAllText(path).Replace('.', ','); // Локализуем числа для текущей культуры
            string[] numbers = fileContent.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double plus = 0;  // Сумма положительных чисел
            double minus = 0; // Сумма отрицательных чисел

            foreach (string number in numbers)
            {
                // Преобразуем строку в double
                double value = Convert.ToDouble(number, CultureInfo.InvariantCulture);

                if (value > 0)
                {
                    plus += value; // Суммируем положительные числа
                }
                else
                {
                    minus += value; // Суммируем отрицательные числа
                }
            }

            double res = Math.Round(plus - minus, 3); // Вычисляем разницу с округлением до 3 знаков
            return res;
        }
    }
}