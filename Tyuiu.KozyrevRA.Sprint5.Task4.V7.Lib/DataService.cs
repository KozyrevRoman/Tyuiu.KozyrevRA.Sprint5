using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KozyrevRA.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = Convert.ToDouble(strx);
            double res = Math.Round((1/Math.Cos(x))+Math.Pow(x, 3), 3);
            return res;
        }
    }
}
