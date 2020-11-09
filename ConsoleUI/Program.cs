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
        /* The Program has been Updated: 
         * 
         * 
         * To-Do
         * Add A Winform Ui
         * MultiThreding on File move (Max two threads)
         */
        static void Main(string[] args)
        {
            
            Console.WriteLine("File Mover");
            Console.WriteLine(@"Please Enter the Destination Folder anywhere on desktop if it is inside a Folder please use the following format: Example\Example");

            bool enterData = true;
            List<string> fileDestinations = new List<string>();
            List<string> fileExtensions = new List<string>();
            string path;

            bool createPath = false;
            Console.WriteLine("Do you want the Destination to be Created Yes/No");
            string createPathText = Console.ReadLine();

            if (!CompairString(createPathText, "yes"))
            {
                createPath = true;
            }

            while (enterData)
            {
                fileDestinations.Add(Console.ReadLine());
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileDestinations.Last());

                if (!FileManager.checkDestination(createPath,path))
                {
                    Directory.CreateDirectory(path);
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to enter more files (yes/no)");
                string Continue = Console.ReadLine();

                if (!CompairString(Continue, "yes"))
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

                if (!CompairString(Continue,"yes"))
                {
                    enterData = false;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Preparing to Move:");

            string Destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            foreach (var desination in fileDestinations)
            {
                foreach (var extension in fileExtensions)
                {
                    FileManager.MoveFiles(desination, extension,rootPath,Destination);
                }
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static bool CompairString(string textToCompair,string comapiredWith)
        {
            return string.Equals(textToCompair, comapiredWith, StringComparison.OrdinalIgnoreCase);
        }
    }
}
