using System;

namespace HTMLeditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }

        public static void DrawScreen()
        {
            Console.WriteLine($"+");
            for (int i = 0; i <= 30; i++)
                Console.Write($"-");
            Console.WriteLine($"+");
            Console.Write($"\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.WriteLine($"|");
                for (int i = 0; i <= 30; i++)
                    Console.Write($" ");
                Console.Write($"|");
                Console.WriteLine($"\n");
                
                Console.WriteLine($"+");
                for (int i = 0; i <= 30; i++)
                    Console.Write($"-");
                Console.WriteLine($"+");
                Console.Write($"\n");
                
                //create a function to improve the code quality
            }
            
            
            
        }
        
        
    }
}