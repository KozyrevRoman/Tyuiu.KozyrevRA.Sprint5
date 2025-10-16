using Tyuiu.KozyrevRA.Sprint5.Task5.V22.Lib;
namespace Tyuiu.KozyrevRA.Sprint5.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask5V22.txt"; 
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
