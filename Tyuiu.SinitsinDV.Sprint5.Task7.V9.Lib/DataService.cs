using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;
namespace Tyuiu.SinitsinDV.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            string[] paths = { @"c:\DataSprint5", "OutPutDataFileTask7V9.txt" };
            string pathSaveFile = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExist = fileInfo.Exists;

            if(fileExist)
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
