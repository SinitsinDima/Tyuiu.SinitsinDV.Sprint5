using Tyuiu.SinitsinDV.Sprint5.Task5.V12.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #5                                         *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла    *");
            Console.WriteLine("* Задание #5                                        *");
            Console.WriteLine("* Вариант #12                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Найти разницу между суммой всех положительных и   *");
            Console.WriteLine("* отрицательных целых чисел в файле.Полученный      *");
            Console.WriteLine("* результат вывести на консоль.                     *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask5V12.txt" };
            string fullPath = Path.Combine(paths);
            Console.WriteLine("Данные находятся в файле: " + fullPath);
            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            double res = ds.LoadFromDataFile(fullPath);
            Console.WriteLine("Разность элементов файла: " + res);

        }
    }
}
