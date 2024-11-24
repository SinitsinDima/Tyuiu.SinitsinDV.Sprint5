using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.SinitsinDV.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            
            string strX = File.ReadAllText(path).Replace('.', ',');
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);
            double res = Math.Round((4.26 * Convert.ToDouble(strX)) / Math.Sin(Convert.ToDouble(strX)), 3);
            return res;
        }
    }
}
