using Tyuiu.SinitsinDV.Sprint5.Task3.V1.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string[] paths = { @"c:\Users", "ִלטענטי", "source", "repos", "Tyuiu.SinitsinDV.Sprint5", "Tyuiu.SinitsinDV.Sprint5.Task3.V1", "bin", "Debug", "OutPutFileTask3.bin" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}