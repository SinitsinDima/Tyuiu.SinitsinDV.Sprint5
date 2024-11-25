using Tyuiu.SinitsinDV.Sprint5.Task5.V12.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask5V12.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}