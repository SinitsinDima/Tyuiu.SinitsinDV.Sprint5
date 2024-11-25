using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
using System.Numerics;
using Microsoft.Win32.SafeHandles;
namespace Tyuiu.SinitsinDV.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace('.', ',');

            double res = 0;
            double plus = 0;
            string line;
            double minus = 0;
            using (StreamReader reader = new StreamReader(path))
            {

                

                while ((line = reader.ReadLine()) != null)
                {

                    if (Convert.ToDouble(line) > 0)
                    {
                        plus += plus;
                    }
                    else
                    {
                        minus += minus;
                    }
                    res = plus - minus;

                }
                return res;
            
            }
            
                



        }
    }
}
