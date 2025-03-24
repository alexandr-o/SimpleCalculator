using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введіть a: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть b: ");
                double b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Виберіть дію\n1. Додавання\n2. Віднімання\n3. Множення\n4. Ділення\n0. Вихід\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                // switch для реалізації вибору операції
                switch (choice)
                {
                    case 1: { Console.WriteLine($"{a} + {b} = {a + b} "); break; }
                    case 2: { Console.WriteLine($"{a} - {b} = {a - b}"); break; }
                    case 3: { Console.WriteLine($"{a} * {b} = {a * b}"); break; }
                    case 4: { Console.WriteLine($"{a} / {b} = {a / b}"); break; }
                    case 0: return;
                    default: { Console.WriteLine("Неправильна дія"); break; }
                }
            }
        }
    }
}
