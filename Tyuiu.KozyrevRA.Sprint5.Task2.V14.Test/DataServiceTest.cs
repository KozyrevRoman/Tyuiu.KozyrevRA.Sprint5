using Tyuiu.KozyrevRA.Sprint5.Task2.V14.Lib;
namespace Tyuiu.KozyrevRA.Sprint5.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\GIGABYTE\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
