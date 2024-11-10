using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SinitsinDV.Sprint5.Task0.V12.Lib
{
    public class DataService : ISprint5Task0V12
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = Math.Pow(x, 3) / (2 * Math.Pow((x + 5), 2));
            y = Math.Round(y, 3);
            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}
