using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KozyrevRA.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            double res = Math.Round(x/(Math.Sqrt(x*x+x)), 3);

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            File.WriteAllText(path, Convert.ToString(res)); 

            return path;
        }
    }
}
