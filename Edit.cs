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