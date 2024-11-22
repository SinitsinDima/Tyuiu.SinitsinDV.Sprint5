using Tyuiu.SinitsinDV.Sprint5.Task1.V18.Lib;
using System.IO;
using System.Diagnostics;
namespace Tyuiu.SinitsinDV.Sprint5.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string[] paths = { @"c:\Users", "ִלטענטי", "source", "repos", "Tyuiu.SinitsinDV.Sprint5", "Tyuiu.SinitsinDV.Sprint5.Task1.V18", "bin", "Debug", "OutPutFileTask1.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        
        }
    }
}