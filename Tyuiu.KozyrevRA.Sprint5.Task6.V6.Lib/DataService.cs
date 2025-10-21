using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.KozyrevRA.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                foreach (char c in line = reader.ReadLine())
                {
                    if ((c >= 'а' && c <= 'я') || c == 'ё')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
