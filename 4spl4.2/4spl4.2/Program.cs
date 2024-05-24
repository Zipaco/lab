using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4spl4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"C:\Users\Марк\source\repos\4spl4.2\test.txt");
            Regex regex = new Regex(@"^\w{5,}$");

            for (int i = 0; i < input.Length; ++i)
            {
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine($"Строка {i+1} соответствует шаблону.");
                }
                else
                {
                    Console.WriteLine($"Строка {i+1} не соответствует шаблону.");
                }
            }

            Console.ReadKey();
        }
    }
}
