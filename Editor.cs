using System;
using System.IO;
using System.Text;
using static System.Console;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Clear();
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            WriteLine("MODO EDITOR");
            WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(ReadLine());
                file.Append(Environment.NewLine);
            } while (ReadKey().Key != ConsoleKey.Escape);

            WriteLine("-----------");
            WriteLine(" Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());

        }

    }
}