using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4spl4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"C:\Users\Марк\source\repos\4spl4.3\test.txt");
            Regex regex = new Regex(@"ул\.\s*(\D+)\s*д\.\s*(\d+\/\d+)");

            for (int i = 0; i < input.Length; ++i)
            {
                Match match = regex.Match(input[i]);
                if (match.Success)
                {
                    string streetName = match.Groups[1].Value;
                    string houseNumber = match.Groups[2].Value;
                    Console.WriteLine($"Улица: {streetName}, Номер дома: {houseNumber}");
                }
                else
                {
                    Console.WriteLine("Не найдено");
                }
            }
            Console.ReadKey();
        }
    }
}
