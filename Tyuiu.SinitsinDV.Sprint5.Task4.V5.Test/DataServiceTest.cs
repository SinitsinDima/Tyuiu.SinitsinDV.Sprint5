using Tyuiu.SinitsinDV.Sprint5.Task4.V5.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask4V5.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}