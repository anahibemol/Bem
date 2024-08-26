using System.Reflection;

namespace Bem
{
    class Utils
    {
        public static void ClearLine(int j)
        {

            for (int i = 1; i <= j; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.WriteLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }

        }

        public static string Help(string Argument)
        {
            string file = Argument.TrimStart('-');
            string text = "";        
            string path = string.Empty;
            path = string.Empty + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int indexRemoval = path.LastIndexOf("Bem");
            if (indexRemoval >= 0) path = path.Remove(indexRemoval);
            path = path + $"Bem\\help\\{file}.txt";

            string[] textArray = File.ReadAllLines(path);
            text = String.Concat(textArray);
            Console.WriteLine(text);

            return text;

        }


    }
}