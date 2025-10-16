using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint5.Task5.V22.Lib;
namespace Tyuiu.KozyrevRA.Sprint5.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Козырев Р. А. | СМАРТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Потоковый метод записи данных в бинарный файл                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V22.txt в котором есть набор*");
            Console.WriteLine("* значений.Найти минимальное целое число в файле, которое делится на 4.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = $@"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask5V22.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное из элементов, делящихся на 4 = "+ res);
            Console.ReadKey();
        }
    }
}