using Tyuiu.SinitsinDV.Sprint5.Task2.V29.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 9, 2, 5 }, 
                                          { 3, 2, 4 }, 
                                          { 2, 8, 8 }};


            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #5                                         *");
            Console.WriteLine("* Тема: Запись структурированных данных в txt       *");
            Console.WriteLine("* Задание #2                                        *");
            Console.WriteLine("* Вариант #29                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементо*");
            Console.WriteLine("* заполненный значениями с клавиатуры. Заменить     *");
            Console.WriteLine("* нечетные элементы массива на 0.                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i,j]} \t");
                }

                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");

        }
    }
}
