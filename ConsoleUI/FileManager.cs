using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    static class  FileManager
    {
        public static bool checkDestination(bool createDestination,string path)
        { 
            if (createDestination)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
            }
            else
            {
                return Directory.Exists(path);
            }
            return false;
        }

        private static string[] GetFilesToMove(string rootPath, string Extension)
        {
            return Directory.GetFiles(rootPath, $"*.{Extension}");
        }
        public static void MoveFiles(string newLocation, string Extension,string rootPath,string Destination)
        {
            newLocation = Path.Combine(Destination, newLocation);
            string[] filesToMove = GetFilesToMove(rootPath, Extension);

            foreach (var file in filesToMove)
            {
                string newFileName = UnwantedTextRemover(Path.GetFileName(file), "y2mate.com - ");
                newFileName = Path.Combine(newLocation, newFileName);
                File.Move(file, newFileName);
                Console.WriteLine("Moving File " + Path.GetFileName(file));
            }
        }

        private static string UnwantedTextRemover(string text, string unwanted)
        {
            return text.Contains(unwanted) ? text.Replace(unwanted, "") : text;
        }
    }
}
