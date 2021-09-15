using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            string celsius;

            Console.WriteLine(" ");
            Console.Write("Olá Habitantes do planeta ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Terra!");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(@"No decorrer desse programa, irei converter
valores de Celsius para Fahrenheit.");
            Console.WriteLine(" ");

            Console.Write("Digite um valor..: ");
            celsius = Console.ReadLine();
            double Dc = Convert.ToDouble(celsius);
            Console.WriteLine(" ");
            Console.WriteLine($"°C = {Dc}");

            double F = (Dc * 1.8) + 32;

            Console.WriteLine(" ");
            Console.WriteLine($"{celsius}°C equivalem a {F}°F");

        }
    }
}
