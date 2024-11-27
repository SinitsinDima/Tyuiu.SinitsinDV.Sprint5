using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.SinitsinDV.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            // Проверяем существование входного файла
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Входной файл не найден: {path}");
            }

            // Убедимся, что папка для выходного файла существует
            string outputDir = @"c:\DataSprint5";
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            // Указываем путь к выходному файлу
            string outputFilePath = Path.Combine(outputDir, "OutPutDataFileTask7V9.txt");

            // Удаляем выходной файл, если он существует
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }

            // Обрабатываем строки из входного файла
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Удаляем заглавные латинские буквы
                    string processedLine = Regex.Replace(line, "[A-Z]", string.Empty);

                    // Записываем обработанную строку в выходной файл
                    File.AppendAllText(outputFilePath, processedLine + Environment.NewLine);
                }
            }

            return outputFilePath; // Возвращаем путь к выходному файлу
        }
    }
}
