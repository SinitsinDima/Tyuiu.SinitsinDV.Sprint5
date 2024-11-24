using Tyuiu.SinitsinDV.Sprint5.Task4.V5.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #5                                         *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла           *");
            Console.WriteLine("* Задание #4                                        *");
            Console.WriteLine("* Вариант #5                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V0.txt    *");
            Console.WriteLine("* в котором есть вещественное значение.Прочитать    *");
            Console.WriteLine("* значение из файла и подставить вместо Х в формуле *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask4V5.txt" };
            string fullPath = Path.Combine(paths); ;

            Console.WriteLine("Данные находятся в файле: " + fullPath);



            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            double res = ds.LoadFromDataFile(fullPath);
            Console.WriteLine(res);
        }
    }
}
