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
            
            for (int i = 0; i <= 30; i++)
                Console.Write($"-");
            Console.Write($"\n");
            
            
            
        }
    }
}