using Tyuiu.SinitsinDV.Sprint5.Task0.V12.Lib;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.SinitsinDV.Sprint5.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            bool fileExists = File.Exists(path);

            Assert.IsTrue(fileExists, "Файл не был создан");

            
            string content = File.ReadAllText(path);
            double expected = Math.Round(Math.Pow(3, 3) / (2 * Math.Pow((3 + 5), 2)), 3);
            Assert.AreEqual(expected.ToString(), content, "Содержимое файла некорректно");
        }
    }
}