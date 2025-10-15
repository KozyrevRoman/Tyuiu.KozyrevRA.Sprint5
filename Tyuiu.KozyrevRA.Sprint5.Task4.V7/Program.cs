using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint5.Task4.V7.Lib;
namespace Tyuiu.KozyrevRA.Sprint5.Task4.V7
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt в котором есть       *");
            Console.WriteLine("* вещественное значение.Прочитать значение из файла и подставить вместо Х *");
            Console.WriteLine("* в формуле:                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                1                                                        *");
            Console.WriteLine("*    y =    ------------  + x^3                                            *");
            Console.WriteLine("*             cos(x)                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = $@"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask4V7.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************"); 

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}