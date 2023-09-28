using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите что вы хотите: \n 1 - калькулятор\n 2 - решение квадратного уравнения");

            if (Console.ReadLine() == "1")
            {
                string[] parts = Console.ReadLine().Split();

                switch (parts[1])
                {
                    case "+":
                        Console.WriteLine(Convert.ToDouble(parts[0]) + Convert.ToDouble(parts[2]));
                        break;
                    case "-":
                        Console.WriteLine(Convert.ToDouble(parts[0]) - Convert.ToDouble(parts[2]));
                        break;
                    case "*":
                        Console.WriteLine(Convert.ToDouble(parts[0]) * Convert.ToDouble(parts[2]));
                        break;
                    case "/":
                        Console.WriteLine(Convert.ToDouble(parts[0]) / Convert.ToDouble(parts[2]));
                        break;
                    case "^":
                        Console.WriteLine(Math.Pow(Convert.ToDouble(parts[0]), Convert.ToDouble(parts[2])));
                        break;
                    case "sqrt":
                        Console.WriteLine(Math.Pow(Convert.ToDouble(parts[2]), 1 / Convert.ToDouble(parts[0])));
                        break;
                    case "%":
                        Console.WriteLine(Convert.ToDouble(parts[0]) % Convert.ToDouble(parts[2]));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите значения a b и c через пробел");

                string[] part = Console.ReadLine().Split();
                double a = Convert.ToDouble(part[0]);
                double b = Convert.ToDouble(part[1]);
                double c = Convert.ToDouble(part[2]);

                double D = b * b - 4 * a * c;

                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("x1 = " + x1 + "\nx2= " + x2);
            }

            Console.ReadKey();
        }
    }
}