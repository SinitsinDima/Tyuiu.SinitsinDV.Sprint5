using Tyuiu.SinitsinDV.Sprint5.Task7.V9.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #5                                         *");
            Console.WriteLine("* Тема: Добавление итоговых проектов по спринту     *");
            Console.WriteLine("* Задание #7                                        *");
            Console.WriteLine("* Вариант #9                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Удалить все заглавные латинские буквы из файла.   *");
            Console.WriteLine("* Полученный результат сохранить в файл             *");
            Console.WriteLine("* OutPutDataFileTask7V9.txt.                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            string[] path = { @"c:\DataSprint5", "InPutDataFileTask7V9.txt " };
            string pathFile = Path.Combine(path);

            string[] pathSaveFile = { @"c:\DataSprint5", "OutPutDataFileTask7V9.txt" };
            string fullPathSaveFile = Path.Combine(pathSaveFile);

            Console.WriteLine("Данные находятся в файле: " + pathFile );

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Находится в файле: ");
            fullPathSaveFile = ds.LoadDataAndSave(pathFile);
            Console.WriteLine(fullPathSaveFile);


        }
    }
}
