using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            // Создадим коллекцию сортированного списка
            SortedList<string, string> CarInfo = new SortedList<string, string>();
            // Добавление элементов
                CarInfo.Add("Audi", "2015");
                CarInfo.Add("Toyota", "2016");
            CarInfo.Add("BMW", "2015");
                CarInfo.Add("Renault", "2014");
                CarInfo.Add("Lexus", "2016");
            // Коллекция ключей
            ICollection<string> keys = CarInfo.Keys; Console.OutputEncoding = Encoding.GetEncoding(866);
            // Теперь используем ключи, для получения значений             
            foreach (string S in keys)
                Console.WriteLine("Марка: {0}, Год: {1}", S, CarInfo[S]);
            Console.ReadLine();
        }
    }
}