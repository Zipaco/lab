using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Class1
    {
        public class CheckingLetters
        {
            public string GenerateLetters(int N)
            {
                if (N < 1 || N > 26)
                    throw new ArgumentException("N должно быть от 1 до 26");

                return string.Concat(Enumerable.Range(0, N).Select(i => (char)('A' + i)));
            }

            //public class Geometry
            //{
            //    public int CalculateArea(int a, int b)
            //    {
            //        if (a < 0 || b < 0) throw new System.ArgumentException();
            //        return a * b;
            //    }
            //}

        }

        public class QuadraticEquation
        {
            public double[] Solve(double a, double b, double c)
            {
                if (a == 0) throw new ArgumentException("Коэффициент a не может быть равен нулю.");

                double discriminant = b * b - 4 * a * c;
                if (discriminant > 0)

                    return new double[] { (-b + Math.Sqrt(discriminant)) / (2 * a), (-b - Math.Sqrt(discriminant)) / (2 * a) };

                else if (discriminant == 0)

                    return new double[] { -b / (2 * a) };

                else

                    return new double[0];
            }
        }

        public class YearDays1
        {
            public int DaysInYear(int year)
            {
                if (year <= 0) throw new ArgumentException("Год должен быть положительным целым числом.");

                return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? 366 : 365;
            }
        }

        public class EmailCheck
        {
            private static readonly Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            public bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email не может быть пустым.");
                return emailRegex.IsMatch(email);
            }
        }

        public class NumberSum
        {
            public int SumOfNumber(string number)
            {
                if (string.IsNullOrWhiteSpace(number))
                    throw new ArgumentException("Input cannot be null or empty.");
                if (!int.TryParse(number, out _)) throw new ArgumentException("Строка должна представлять собой положительное целое число.");

                return number.Sum(c => c - '0');
            }
        }

    }
}
