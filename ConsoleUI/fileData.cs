using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class FileData
    {
        private List<string> fileType = new List<string>();
        public List<string> fileExtensions;

       private enum FileType
        {
            Audio,
            Video,
            Executable,
            Compressed,
            Image,
            Default
        }

        public FileData(int type)
        {
            FileType fileType;
            switch (type)
            {
                case 1:
                    fileType = FileType.Audio;
                    break;
                case 2:
                    fileType = FileType.Video;
                    break;
                case 3:
                    fileType = FileType.Compressed;
                    break;
                case 4:
                    fileType = FileType.Executable;
                    break;
                case 5:
                    fileType = FileType.Image;
                    break;
                default:
                    fileType = FileType.Default;
                    break;
            }
            switch(fileType)
            {
                case FileType.Video:
                   this.fileExtensions = VideoData();
                    break;
                case FileType.Audio:
                    this . fileExtensions = AudioData();
                    break;
                case FileType.Compressed:
                    this.fileExtensions = CompressedData();
                    break;
                case FileType.Executable:
                    this.fileExtensions = ExecutableData();
                    break;
                case FileType.Image:
                    this.fileExtensions =ImageData();
                     break;
                case FileType.Default:
                    this.fileExtensions = new List<string>();
                    break;
            }
        }

        private List<string> AudioData()
        {
            fileType.Add("aif");
            fileType.Add("cda");
            fileType.Add("mid");
            fileType.Add("midi");
            fileType.Add("mp3");
            fileType.Add("mpa");
            fileType.Add("ogg");
            fileType.Add("wav");
            fileType.Add("wma");
            fileType.Add("wpl");

            return fileType;
        }
        private List<string> VideoData()
        {
            fileType.Add("3g2");
            fileType.Add("3gp");
            fileType.Add("avi");
            fileType.Add("flv");
            fileType.Add("h264");
            fileType.Add("m4v");
            fileType.Add("mkv");
            fileType.Add("mp4");
            fileType.Add("mov");
            fileType.Add("mpg");
            fileType.Add("mpeg");
            fileType.Add("rm");
            fileType.Add("swf");
            fileType.Add("vob");
            fileType.Add("wmv");

            return fileType;
        }
        private List<string> CompressedData()
        {
            fileType.Add("7z");
            fileType.Add("arj");
            fileType.Add("deb");
            fileType.Add("pkg");
            fileType.Add("rar");
            fileType.Add("rpm");
            fileType.Add("tar.gz");
            fileType.Add("z");
            fileType.Add("zip");

            return fileType;
        }
        private List<string> ExecutableData()
        {
            fileType.Add("apk");
            fileType.Add("bat");
            fileType.Add("bin");
            fileType.Add("cgi");
            fileType.Add("pl");
            fileType.Add("com");
            fileType.Add("exe");
            fileType.Add("gadget");
            fileType.Add("jar");
            fileType.Add("msi");
            fileType.Add("py");
            fileType.Add("wsf");

            return fileType;
        }
        private List<string> ImageData()
        {
            fileType.Add("ai");
            fileType.Add("bmp");
            fileType.Add("gif");
            fileType.Add("ico");
            fileType.Add("jpeg");
            fileType.Add("jpg");
            fileType.Add("png");
            fileType.Add("ps");
            fileType.Add("psd");
            fileType.Add("svg");
            fileType.Add("tif");
            fileType.Add("tiff");

            return fileType;
        }
    }
}
