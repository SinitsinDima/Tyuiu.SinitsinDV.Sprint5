using Tyuiu.SinitsinDV.Sprint5.Task6.V29.Lib;
using System.IO;
namespace Tyuiu.SinitsinDV.Sprint5.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask6V29.txt" };
            string fullPath = Path.Combine(paths);

            var res = ds.LoadFromDataFile(fullPath);
            int wait = 3;
            Assert.AreEqual(wait, res);



        }

            [TestMethod]
        public void LoadFromDataFile()
        {
            string[] paths = { @"c:\DataSprint5", "InPutDataFileTask6V29.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}