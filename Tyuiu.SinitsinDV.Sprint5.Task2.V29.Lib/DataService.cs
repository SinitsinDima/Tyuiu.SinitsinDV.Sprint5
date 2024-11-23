using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }


            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;

                    }
                }
            }


            string str ="";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if(j != colums-1)
                    {
                        str = str + matrix[i, j]+";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if(i != rows-1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);

                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }
            return path;


        }
    }
}
