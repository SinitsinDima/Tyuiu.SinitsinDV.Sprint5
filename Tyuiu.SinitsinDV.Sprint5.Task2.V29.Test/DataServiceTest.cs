using Tyuiu.SinitsinDV.Sprint5.Task2.V29.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string[] paths = { @"c:\Users", "ִלטענטי", "source", "repos", "Tyuiu.SinitsinDV.Sprint5", "Tyuiu.SinitsinDV.Sprint5.Task2.V29", "bin", "Debug", "OutPutFileTask2.csv" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}