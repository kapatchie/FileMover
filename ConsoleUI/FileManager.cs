using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ConsoleUI
{
    static class FileManager
    {
        public static bool checkDestination(bool createDestination, string path)
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
        public static void MoveFile(string newLocation, string Extension, string rootPath, string Destination)
        {
            newLocation = Path.Combine(Destination, newLocation);
            string[] filesToMove = GetFilesToMove(rootPath, Extension);

            foreach (var file in filesToMove)
            {
                string newFileName = UnwantedTextRemover(Path.GetFileName(file), "y2mate.com - ");
                newFileName = Path.Combine(newLocation, newFileName);
                if (!File.Exists(newFileName))
                {
                    File.Move(file, newFileName);
                    Console.WriteLine("Moving File " + Path.GetFileName(file));
                }
                else
                { Console.WriteLine($"File :{ Path.GetFileName(file)} all ready exists skipping file "); }
            }
        }

        private static string UnwantedTextRemover(string text, string unwanted)
        {
            return text.Contains(unwanted) ? text.Replace(unwanted, "") : text;
        }
        public static void saveData(List<string> fileDestinations)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data");
            string fileDestinationPath = path + @"\fileDestinations.txt";
            StringBuilder sb = new StringBuilder();
            StreamWriter sw;

            try
            {
                sw = new StreamWriter(fileDestinationPath, true, Encoding.UTF8);
                foreach (var destination in fileDestinations)
                {
                    sb.Append(destination).Append(',');
                }
                sw.WriteLine(sb);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                sb.Clear();
            }
        }

        public static List<string> loadData(string type)
        {
            List<string> dataList = new List<string>();
            try
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data");
                string text = File.ReadAllText(path + type);

                text = text.Replace(Environment.NewLine, string.Empty);
                string[] dataArray = text.Split(',');

                foreach (var data in dataArray)
                {
                    if (!string.IsNullOrEmpty(data))
                    {
                        dataList.Add(data);
                    }
                }
                return dataList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return dataList;
            }
        }
    }
}
