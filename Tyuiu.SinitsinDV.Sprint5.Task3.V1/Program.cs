using Tyuiu.SinitsinDV.Sprint5.Task3.V1.Lib;
using System.IO;
using System.Text;
namespace Tyuiu.SinitsinDV.Sprint5.Task3.V1
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
            Console.WriteLine("* Тема:Потоковый метод записи данных в бинарный файл*");
            Console.WriteLine("* Задание #3                                        *");
            Console.WriteLine("* Вариант #1                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3   *");
            Console.WriteLine("* результат сохранить в бинарный файл               *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль.         *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            Console.WriteLine("x: " + x);

            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
        }
    }
}
