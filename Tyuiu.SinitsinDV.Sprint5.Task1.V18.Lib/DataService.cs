using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }


            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {

                if (x == 0)
                {
                    y = 0;
                }


                y = Math.Round(3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1)), 2);
                strY = Convert.ToString(y);

                if (x == 0)
                {
                   y = 0;
                }
                

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }


            }
            return path;


        }
    }
}
