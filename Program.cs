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

        public static void MainMenu()
        {
            Console.WriteLine("Welcome to version 0.0.1 of Bem - Bemol Editing Mediator \n \n" + "Write \"help\" to get started");
            string I = Console.ReadLine() ?? "home";

            Parsing.InitParser(I);
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





    }
}
