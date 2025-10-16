using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KozyrevRA.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                line = line.Replace(".", ",");
                string[] lines1 = line.Split(" ");
                List<string> lines = lines1.ToList();
                foreach (string li in lines)
                {
                    double x = Convert.ToDouble(li);
                    if (x < res)
                    {
                        if (x % 4 == 0)
                        {
                            res = x;
                        }
                    }

                }
            }
            return res;
        }
    }
}
