using Tyuiu.SinitsinDV.Sprint5.Task1.V18.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #5 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #5                                         *");
            Console.WriteLine("* Тема:Класс File.Запись набора данных в txt         ");
            Console.WriteLine("* Задание #1                                        *");
            Console.WriteLine("* Вариант #18                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Начало шага " + startValue);
            Console.WriteLine("Конец шага " + stopValue);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            string path = $@"{Path.GetTempPath()}OutPutFileTask1.txt";
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = 3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1));
                strY = Convert.ToString(y);

                if (x == 0)
                {
                    y = 0;
                }
                y = Math.Round(y, 2);
                Console.WriteLine($"{y}\n");

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
                string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
                


        }
    }
}
