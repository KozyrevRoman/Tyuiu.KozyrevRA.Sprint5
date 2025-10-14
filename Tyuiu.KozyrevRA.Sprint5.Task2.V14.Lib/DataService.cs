using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KozyrevRA.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
                File.Delete(path);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j]>0)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                        File.AppendAllText(path, matrix[i, j] + "");
                    else
                        File.AppendAllText(path, matrix[i, j] + ";");
                }
                File.AppendAllText(path, "\n");
            }

            return path;
        }
    }
}
