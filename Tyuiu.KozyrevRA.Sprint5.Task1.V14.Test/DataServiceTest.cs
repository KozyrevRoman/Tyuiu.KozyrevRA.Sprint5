using Tyuiu.KozyrevRA.Sprint5.Task1.V14.Lib;
namespace Tyuiu.KozyrevRA.Sprint5.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\GIGABYTE\source\repos\Tyuiu.KozyrevRA.Sprint5\Tyuiu.KozyrevRA.Sprint5.Task1.V14\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
