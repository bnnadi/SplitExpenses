using System;
using System.IO; 
using System.Text;

namespace CODING_SCENARIO
{
    class SplitExpenses
    {
        public static string filename;

        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the expenses file you want split?");
            filename = Console.ReadLine();
            String line;
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),  filename + ".txt");
                StreamReader sr = new StreamReader(path);

                line = sr.ReadLine();

                while (line != null)
                {
                    // Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                // throw;
            }
            finally
            {
                Console.WriteLine("File has been read.");
            }

            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), filename +".txt.out");
                StreamWriter sw = new StreamWriter(path);

                sw.WriteLine("Hello World!!");
                sw.WriteLine("From StreamWriter class!!!");

                sw.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                // throw;
            }
            finally
            {
                Console.WriteLine("New File has been created.");
            }
        }
    }
}