using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                List<string> fileDestinations = new List<string>();
                List<string> fileExtensions = new List<string>();

                //fileDestinations.AddRange(FileManager.loadData("\\fileDestinations.txt"));

                bool createPath = false;
                Console.WriteLine("Do you want the Destination to be Created Yes/No");
                string createPathText = Console.ReadLine();
                if (!CompairString(createPathText, "yes"))
                { createPath = true; }

                fileDestinations.AddRange(EnterFileDesitnations(fileDestinations, createPath));
                fileExtensions.AddRange(EnterExtensions(fileExtensions));
                Console.WriteLine("Preparing to Move:");
                if (fileExtensions.Count != 0)
                {
                    Console.WriteLine("Done!");
                }
                MoveFiles(fileDestinations, fileExtensions, createPath);
                Console.WriteLine("Do You want to move more files ?");
                if (!CompairString(Console.ReadLine().ToLower(), "yes"))
                {
                    enterData = false; FileManager.saveData(fileDestinations);
                    Console.ReadLine();
                }
            }
        }

        private static bool CompairString(string textToCompair, string comapiredWith)
        {
            return string.Equals(textToCompair, comapiredWith, StringComparison.OrdinalIgnoreCase);
        }
        private static List<string> EnterFileDesitnations(List<string> fileDestinations, bool createPath)
        {
            Console.WriteLine("Please Enter the Destination Folder anywhere on desktop if it is inside a Folder please use the following format: \n Example\\Example");
            fileDestinations.Add(Console.ReadLine());
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileDestinations.Last());

            if (!FileManager.checkDestination(createPath, path))
            {
                Directory.CreateDirectory(path);
            }

            Console.WriteLine();
            return fileDestinations;
        }
        private static List<string> EnterExtensions(List<string> fileExtensions)
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
                    Console.Clear();
                    Console.WriteLine("Please enter a Numerical Value Between 1 - 5");
                    loop = true;
                }
                if (value >= 6)
                {
                    Console.WriteLine("Please enter a Numerical Value Between 1 - 5");
                    loop = true;
                }

            } while (loop);

            FileData fileData = new FileData(value);
            fileExtensions.AddRange(fileData.fileExtensions);

            return fileExtensions;
        }
        private static void MoveFiles(List<string> fileDestinations, List<string> fileExtensions, bool createPath)
        {
            string Destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            for (int i = 0; i < fileExtensions.Count; i++)
            {
                FileManager.MoveFile(fileDestinations.Last(), fileExtensions[i], rootPath, Destination);
            }
        }
    }
}