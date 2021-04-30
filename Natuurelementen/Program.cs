using System;

namespace Natuurelementen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Druk op Enter om de 4 natuurelementen te zien");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("De 4 natuurelementen zijn");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("water");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 15);
            Console.WriteLine("vuur");

            Console.ResetColor();
            Console.SetCursorPosition(35, 15);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("aarde");

            Console.ResetColor();
            Console.SetCursorPosition(25, 25);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("lucht");
        }
    }
}