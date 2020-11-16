using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Mover");
            bool enterData = true;
            while (enterData)
            {
                List<Repository> fileRepositories = new List<Repository>();

                Console.WriteLine("Do you want to work from a Saved File ? yes/no");

                if (!string.Equals(Console.ReadLine(), "yes", StringComparison.OrdinalIgnoreCase))
                {
                    bool createPath = false;
                    Console.WriteLine("Do you want the Destination to be Created Yes/No");
                    string createPathText = Console.ReadLine();
                    if (!CompairString(createPathText, "yes"))
                    { createPath = true; }
                    fileRepositories.Add(new Repository(EnterFileDesitnations(createPath), GetExtensionsValue()));
                }
                else
                {
                    fileRepositories.AddRange(FileManager.loadData());
                }

                Console.WriteLine("Preparing to Move:");
                FileManager.MoveFiles(fileRepositories);
                Console.WriteLine(UIController.Instance.text);
                Console.WriteLine("Done!");

                Console.WriteLine("Do You want to move more files ?");
                if (!CompairString(Console.ReadLine(), "yes"))
                {
                    enterData = false;
                    FileManager.saveData(fileRepositories);
                    Console.ReadLine();
                }
            }
        }

        private static bool CompairString(string textToCompair, string comapiredWith)
        {
            return string.Equals(textToCompair, comapiredWith, StringComparison.OrdinalIgnoreCase);
        }
        private static string EnterFileDesitnations(bool createPath)
        {
            string Destination;
            Console.WriteLine("Please Enter the Destination Folder anywhere on desktop if it is inside a Folder please use the following format: \n Example\\Example");
            Destination = Console.ReadLine();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Destination);

            FileManager.checkDestination(createPath, path);
            Console.WriteLine();
            return Destination;
        }
        private static int GetExtensionsValue()
        {
            int value;
            bool loop;
            do
            {
                loop = false;
                Console.WriteLine("Please Choose a Number");
                Console.WriteLine("[1] Audio Files");
                Console.WriteLine("[2] Video Files");
                Console.WriteLine("[3] Compressed Files");
                Console.WriteLine("[4] Executable Files");
                Console.WriteLine("[5] Image Files");

                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine(@"Please enter a Numerical Value Between 1 - 5\n\r");
                    loop = true;
                }
                if (value >= 5)
                {
                    Console.WriteLine(@"Please enter a Numerical Value Between 1 - 5\n\r");
                    loop = true;
                }

            } while (loop);
            return value;
        }
        
    }
}
