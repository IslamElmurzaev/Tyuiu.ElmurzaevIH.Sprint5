using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.ElmurzaevIH.Sprint5.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\adami\source\repos\Tyuiu.ElmurzaevIH.Sprint5\Tyuiu.ElmurzaevIH.Sprint5.Task7.V14\bin\Debug\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
