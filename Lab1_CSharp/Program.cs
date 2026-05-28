using System;

namespace Lab1_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Лабораторна робота №1");
            Console.WriteLine("Тема: Розробка елементарних програм на мові C#");
            Console.ResetColor();
            Console.WriteLine();

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введіть перше число: ");
                Console.ResetColor();
                double a = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введіть друге число: ");
                Console.ResetColor();
                double b = Convert.ToDouble(Console.ReadLine());

                double sum = a + b;
                double difference = a - b;
                double product = a * b;
                double power = Math.Pow(a, 2);
                double squareRoot = Math.Sqrt(Math.Abs(b));
                double average = (a + b) / 2;
                int roundedAverage = Convert.ToInt32(Math.Round(average));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результати обчислень:");
                Console.ResetColor();

                Console.WriteLine($"Сума чисел: {Math.Round(sum, 2)}");
                Console.WriteLine($"Різниця чисел: {Math.Round(difference, 2)}");
                Console.WriteLine($"Добуток чисел: {Math.Round(product, 2)}");
                Console.WriteLine($"Перше число у квадраті: {Math.Round(power, 2)}");
                Console.WriteLine($"Квадратний корінь з модуля другого числа: {Math.Round(squareRoot, 2)}");
                Console.WriteLine($"Середнє арифметичне: {Math.Round(average, 2)}");
                Console.WriteLine($"Округлене середнє значення як int: {roundedAverage}");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Програма успішно завершила роботу.");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка: потрібно вводити тільки числа!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Невідома помилка: {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
