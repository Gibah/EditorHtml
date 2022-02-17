using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Clear();
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            WriteLine("MODO VISUALIZAÇÃO");
            WriteLine("-----------");
            Replace(text);
            WriteLine("-----------");
            ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );
                    Write(" ");
                }
                else
                {
                    ForegroundColor = ConsoleColor.Black;
                    Write(words[i]);
                    Write(" ");
                }
            }
        }
    }
}