
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();

        }

        public void Run()
        {

            this.ReadTextFiles();
            this.ProcessArrayList();


        }

        public void ProcessArrayList()
        {
            int LineNumber = 0;

            foreach (var line in Beowulf)
            {
                LineNumber++;
                Console.WriteLine(line);
                if (ContainsWord(line.ToString(), "sea") && ContainsWord(line.ToString(), "Fare"))
                {
                    Console.WriteLine("Line number is: {0}", LineNumber);
                }
            }
        }

        public bool ContainsWord(string line, string word)
        {
           
            if (line.Contains("sea") == true)
            {
            
            }
            return false;
        }

        public void ReadTextFiles()
        {
            
            using (StreamReader file = new StreamReader("U:/Users/732140/Beowulf.txt"))
            {
                //int words = 1;
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }

                
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
               
                Console.WriteLine();
            }

        }

        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }

                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                }
            }
            return countSpaces;
        }
    }
}