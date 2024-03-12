using System;
using System.Collections.Generic;
using System.IO;

namespace l_1_1
{
    class Program
    {
        //Дано текстовий файл.Створіть список, кожен елемент якого містить кількість символів у відповідному рядку тексту.
        static void Main()
        {


            string filePath = "C:\\txt.txt";

            List<int> lineLengths = GetLineLengths(filePath); //получение списка строк 

            foreach (int length in lineLengths)
            {

                Console.WriteLine(length);

            }
            Console.ReadKey();
        }
        static List<int> GetLineLengths(string filePath)
        {
            List<int> lengths = new List<int>();

            if (File.Exists(filePath))
            {


                string[] lines = File.ReadAllLines(filePath);


                foreach (string line in lines)
                {

                    lengths.Add(line.Length);

                }
            }

            return lengths;


        }
    }
}