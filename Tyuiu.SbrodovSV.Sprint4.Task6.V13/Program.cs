using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SbrodovSV.Sprint4.Task6.V13.Lib;

namespace Tyuiu.SbrodovSV.Sprint4.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService dataService = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Сбродов С. В. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Сбродов Степан Владимирович | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Ford\", \"Toyota\", \"Honda\", \"Chevrolet\",    *");
            Console.WriteLine("* \"Mercedes\", \"BMW\", \"Audi\"] используя класс Array подсчитайте количество *");
            Console.WriteLine("* элементов, длина которых больше 4.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] cars = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            Console.Write("Массив: {");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i]);
                if (i != cars.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = dataService.Calculate(cars);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
