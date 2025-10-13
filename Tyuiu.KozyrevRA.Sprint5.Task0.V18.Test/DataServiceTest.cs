using Tyuiu.KozyrevRA.Sprint5.Task0.V18.Lib;
namespace Tyuiu.KozyrevRA.Sprint5.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\GIGABYTE\source\repos\Tyuiu.KozyrevRA.Sprint5\Tyuiu.KozyrevRA.Sprint5.Task0.V18\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo. Exists;   
            bool wait = true;
            Assert. AreEqual(wait, fileExists);
        }
    }
}
