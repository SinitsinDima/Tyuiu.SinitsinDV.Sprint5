using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SinitsinDV.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {


            string tempDir = Path.GetTempPath();  // Получаем путь к временной папке
            string fullSaveFile = Path.Combine(tempDir, @"C:\DataSprint5", "OutPutDataFileTask7V9.txt");  // Генерируем путь к файлу в временной папке
            FileInfo fileInfo = new FileInfo(fullSaveFile);

            if (fileInfo.Exists)
            {
                File.Delete(fullSaveFile);
            }

            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string processedLine = Regex.Replace(line, "[A-Z]", string.Empty);


                    File.AppendAllText(fullSaveFile, processedLine + Environment.NewLine);
                }
            }

            return fullSaveFile;
        }
    }
}
