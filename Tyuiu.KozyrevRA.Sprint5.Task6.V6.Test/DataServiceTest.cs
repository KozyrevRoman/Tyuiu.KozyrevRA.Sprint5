using Tyuiu.KozyrevRA.Sprint5.Task6.V6.Lib; 
namespace Tyuiu.KozyrevRA.Sprint5.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask6V6.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 22;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask6V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
