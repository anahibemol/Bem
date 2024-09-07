using System.Reflection.Metadata;

namespace Bem
{
    class Actions
    {
        public static void Open(string path)
        {
            int i = 0;
            string buffer = string.Empty;
            string bufferSize_String = string.Empty;
            int    bufferSize_Int = 0;
            string[] pathContent = File.ReadAllLines(path);

                Console.WriteLine(path);
                Console.WriteLine();
            foreach(string line in pathContent)
            {
                bufferSize_String = Convert.ToString(i+1);
                bufferSize_Int = bufferSize_String.Length;
                    
                
                pathContent[i] = bufferSizeSwitch(bufferSize_Int) + (i + 1) +  "| " + pathContent[i];
                Console.WriteLine(pathContent[i]);
                i++;
            }
                
            Console.ReadLine();
        }
    
        public static void Edit(string path)
        { 
            Console.WriteLine("Write the text input you want to add to the document");
            string? desiredText = Console.ReadLine();
            Console.WriteLine("Write the number of the line you want to replace");
            int Line = Convert.ToInt16(Console.ReadLine()) -1;
            if (desiredText is not null && Line > 0)
            {
            string[] file = File.ReadAllLines(path);
            file = file.Select((x, i) => i == Line ? x = desiredText : x).ToArray();
            File.WriteAllLines(path, file);
            }

        }
        private static string bufferSizeSwitch(int bufferSize) =>
        bufferSize switch
        {
            1 => "   ",
            2 => "  ",
            3 => " ",
            _ => ""
        };


    }
}