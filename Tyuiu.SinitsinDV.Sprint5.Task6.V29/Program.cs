using Tyuiu.SinitsinDV.Sprint5.Task6.V29.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #5                                         *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                  *");
            Console.WriteLine("* Задание #6                                        *");
            Console.WriteLine("* Вариант #29                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Найти количество слов длиной семь символов        *");
            Console.WriteLine("* в заданной строке.                                *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask6V29.txt" };
            string fullPath = Path.Combine(paths);


            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            int res = ds.LoadFromDataFile(fullPath);
            Console.WriteLine(res);
        }
    }
}
