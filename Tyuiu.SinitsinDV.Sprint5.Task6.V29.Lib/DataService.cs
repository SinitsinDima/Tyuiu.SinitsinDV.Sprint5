using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    
                    count += words.Count(word => word.Length == 7);
                }
                return count;


            }
        }
    }
}
