using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.SinitsinDV.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            // Путь для сохранения выходного файла
            string[] fullpath = { @"c:\DataSprint5", "OutPutDataFileTask7V9.txt" };
            string fullSaveFile = Path.Combine(fullpath);

            // Удаляем выходной файл, если он существует
            if (File.Exists(fullSaveFile))
            {
                File.Delete(fullSaveFile);
            }

            // Читаем строки и обрабатываем их
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Удаляем заглавные латинские буквы
                    string processedLine = Regex.Replace(line, "[A-Z]", string.Empty);

                    // Записываем обработанную строку в выходной файл
                    File.AppendAllText(fullSaveFile, processedLine + Environment.NewLine);
                }
            }

            return fullSaveFile;
        }
    }
}
