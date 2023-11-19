using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.ElmurzaevIH.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\adami\source\repos\Tyuiu.ElmurzaevIH.Sprint5\Tyuiu.ElmurzaevIH.Sprint5.Task1.V29\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
