using System;
using static System.Console;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            BackgroundColor = ConsoleColor.Blue;
            ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Write("+");
            for (int i = 0; i <= 30; i++)
                Write("-");

            Write("+");
            Write("\n");


            for (int lines = 0; lines <= 10; lines++)
            {
                Write("|");
                for (int i = 0; i <= 30; i++)
                    Write(" ");

                Write("|");
                Write("\n");
            }

            Write("+");
            for (int i = 0; i <= 30; i++)
                Write("-");

            Write("+");
            Write("\n");

        }

        public static void WriteOptions()
        {
            SetCursorPosition(3, 1);
            WriteLine("Editor HTML");
            SetCursorPosition(3, 2);
            WriteLine("============");
            SetCursorPosition(3, 3);
            WriteLine("Selecione uma opção abaixo");
            SetCursorPosition(3, 5);
            WriteLine("1 - Novo Arquivo");
            SetCursorPosition(3, 6);
            WriteLine("2 - Abrir");
            SetCursorPosition(3, 7);
            WriteLine("0 - Sair");
            SetCursorPosition(3, 8);
            Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: WriteLine("View"); break;
                case 0:
                    {
                        Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}