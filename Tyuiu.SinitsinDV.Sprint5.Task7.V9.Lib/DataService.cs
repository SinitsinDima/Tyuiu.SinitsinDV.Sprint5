using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;
namespace Tyuiu.SinitsinDV.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {

            string directoryPath = @"C:\DataSprint5"; 
            string fileName = "OutPutDataFileTask7V9.txt";

            

            
            string pathSaveFile = Path.Combine(directoryPath, fileName);

            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            
            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string processedLine = Regex.Replace(line, "[A-Z]", string.Empty);

                    
                    File.AppendAllText(pathSaveFile, processedLine + "\n");
                }
            }

            
            return pathSaveFile;


        }
    }
}
