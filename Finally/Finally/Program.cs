using System;
using System.IO;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("myfile.txt", true);

            try
            {
                file.WriteLine("Test");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            finally
            {
                file.Close();
            }

            using (StreamWriter file2 = new StreamWriter("myfile.txt", true))
            {
                file2.WriteLine("Test2");
            }
        }
    }
}
