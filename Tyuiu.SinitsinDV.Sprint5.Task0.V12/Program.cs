using Tyuiu.SinitsinDV.Sprint5.Task0.V12.Lib;
using System.IO;

namespace Tyuiu.SinitsinDV.Sprint5.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #5                                         *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл  *");
            Console.WriteLine("* Задание #0                                        *");
            Console.WriteLine("* Вариант #12                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3,  *");
            Console.WriteLine("* результат сохранить в текстовый файл              *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль.         *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("x: " + x);

            string filePath = ds.SaveToFileTextData(x);
            string result = File.ReadAllText(filePath);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Файл: " + filePath);
            Console.WriteLine("Создан!");
            Console.WriteLine("Результат вычисления y: " + result);
        }
    }
}
