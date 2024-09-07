namespace Bem
{
    public class Parsing
    {
        public static void InitParser(string i)
        {
            List<string> Arguments = new();
            List<string> Paths = new();
            List<string> Commands = new();
            string[] substrings = i.Split(' ');
            string[] Path = i.Split("C:");

            for (int i2 = 0; i2 < substrings.Length; i2++)
            {
                if (substrings[i2].IndexOf("-") != -1)
                {
                    substrings[i2] = substrings[i2].TrimStart('-');
                    Arguments.Add(substrings[i2]);
                    Console.WriteLine(substrings[i2]);
                }

                else if (substrings[i2].Contains("C:") == true)
                {
                    Paths.Add(substrings[i2]);
                }

                else
                {
                    Commands.Add(substrings[i2]);
                }

            }
            if (Paths.Count == 0) { Paths.Add(""); }
            if (Arguments.Count == 0) { Arguments.Add(""); }
            Paths[0] = Path[^1];
            Init(Arguments[0], Paths[0], Commands[0]);
        }
        private static void Init(string Argument, string Path, string Command)
        {

            switch (Command)
            {
                case "edit": 
                switch(Argument)
                {
                    case "open": Actions.Open(Path); break;
                    case "edit": Actions.Edit(Path); break;
                }
                break;
                case "home": Menu.MainMenu(); break;
                case "help": Console.WriteLine(Utils.Help(Argument)); break;
            }

        }

    }
}