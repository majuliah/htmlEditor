﻿using System;

namespace HTMLeditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            
            DrawScreen();
            WriteOption();

            short option = short.Parse(Console.ReadLine());

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

        public static void WriteOption()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine($"HTML EDITOR");
            Console.SetCursorPosition(3,4);
            Console.WriteLine($"Select an option");
            Console.SetCursorPosition(3,6);
            Console.WriteLine($"1 - New file");
            Console.SetCursorPosition(3,7);
            Console.WriteLine($"2 - Open");
            Console.SetCursorPosition(3,9);
            Console.WriteLine($"0 - Out");
            Console.SetCursorPosition(3,10);
            Console.WriteLine($"Option: ");
            
            
        }
    }
}