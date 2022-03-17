using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HTMLeditor
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.Clear();
            Console.WriteLine($"Modo Visualização! ");
            Console.WriteLine($"-------------------");
            Replace(text);
            Console.WriteLine($"-------------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex($@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            Console.WriteLine(strong);
            
        }
    }
}