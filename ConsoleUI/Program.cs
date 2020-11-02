using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        /*The Goal of this program is to move files based on their extension name to a specified folder on desktop 
         * it the file name contains "y2mate" it is to be removed for the name 
         * The files must be able to go as deep into the directory as chosen
         */
        static void Main(string[] args)
        {
            Console.WriteLine("File Mover");
            Console.WriteLine(@"Please Enter the Destination Folder anywhere on desktop if it is inside a Folder please use the following format: Example\Example");

            bool enterData = true;
            List<string> fileDestinations = new List<string>();
            List<string> fileExtensions = new List<string>();
            string path;

            while (enterData)
            {
                fileDestinations.Add(Console.ReadLine());
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileDestinations.Last());

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to enter more files (yes/no)");
                string Continue = Console.ReadLine();

                if (!string.Equals(Continue, "yes", StringComparison.OrdinalIgnoreCase))
                {
                    enterData = false;
                }

                Console.WriteLine();
            }

            enterData = true;

            while (enterData)
            {
                Console.WriteLine("Please enter a file extension");
                fileExtensions.Add(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Do you want to enter more files (yes/no)");
                string Continue = Console.ReadLine();

                if (!string.Equals(Continue, "yes", StringComparison.OrdinalIgnoreCase))
                {
                    enterData = false;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Preparing to Move:");

            foreach (var desination in fileDestinations)
            {
                foreach (var extension in fileExtensions)
                {
                    MoveFiles(desination, extension);
                }
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        private static string[] GetFilesToMove(string rootPath, string Extension)
        {
            return Directory.GetFiles(rootPath, $"*.{Extension}");
        }
        private static void MoveFiles(string newLocation,string Extension)
        {
            newLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),newLocation);
            string rootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string[] filesToMove = GetFilesToMove(rootPath,Extension);

            foreach (var file in filesToMove)
            {
                string newFileName = UnwantedTextRemover(Path.GetFileName(file), "y2mate.com -");
                newFileName = Path.Combine(newLocation, Path.GetFileName(file));
                File.Move(file, newFileName);
                Console.WriteLine("Moving File " + Path.GetFileName(file));
            }
        }

        private static string UnwantedTextRemover(string text,string unwanted)
        {
             return text.Contains(unwanted) ?  text.Replace(unwanted,"") : text;
        }
    }
}
