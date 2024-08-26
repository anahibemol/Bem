using System;

namespace Bem
{
    public static class Menu
    {
        static void Main(string[] args)
        {
            MainMenu();
            //Edit.Open("C:\\Users\\nulos\\Documentos\\GitHub\\SOIS-Explorer\\SØIS Explorer\\Management.cs");
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to version 0.0.1 of Bem - Bemol Editing Mediator \n \n" + "Write \"help\" to get started");
            string I = Console.ReadLine() ?? "home";

            Parser(I);
         /*   
            switch (I)
            {
                case "home":
                    Utils.ClearLine(5);
                    Console.WriteLine();
                    MainMenu();
                    break;

                case "help":
                    Console.WriteLine(Utils.Help("main"));

                    break;

                case "edit":
                    Edit.Open("C:\\Users\\nulos\\Documentos\\GitHub\\Bem\\Utils.cs");
                    break;
            }
        */
        }

        public static void Parser(string i)
        {
            List<string> Arguments = new();
            List<string> Paths = new();
            List<string> Commands = new();
            string[] substrings = i.Split(' ');

            for(int i2 = 0; i2 < substrings.Length; i2++)
            {
                if ( substrings[i2].IndexOf("-") != -1 )
                {
                    substrings[i2] = substrings[i2].TrimStart('-');
                    Arguments.Add(substrings[i2]);
                    Console.WriteLine(substrings[i2]);
                }

                else if (substrings[i2].Contains('\\') == true)
                {
                    Paths.Add(substrings[i2]);
                }

                else
                {
                    Commands.Add(substrings[i2]);
                }

            }
                if(Paths.Count == 0) {Paths.Add(" ");}
                Init(Arguments[0], Paths[0], Commands[0]);
        }

            static void Init(string Argument, string Path, string Command)
            {

            switch(Command)
            {
                case "edit": Actions.Open(Path); break;
                case "home": MainMenu(); break;
                case "help": Console.WriteLine(Utils.Help(Argument)); break;
            }

            }
    }
}
