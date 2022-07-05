using System;
using System.IO;
namespace FileIO

{
    class Program
    {
        public static void FileExist()
        {
            string InputFile = @"G:\visualstudio\FileIOTextFile\FileIO.txt";
            if(File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("not Exist");
            }
        }
        public static void ReadFile()
        {
            string InputFile = @"G:\visualstudio\FileIOTextFile\FileIO.txt";
            using (StreamReader read = new StreamReader(InputFile))
            {
                string s = "";
                while ((s = read.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                read.Close();
            }
        }
        public static void CopyFile()
        {
            string path = @"G:\visualstudio\FileIOTextFile\FileIO.txt";
            string CopyPath = @"G:\visualstudio\FileIOTextFile\FileIO1.txt";
            File.Copy(path, CopyPath);
        }
        public static void DeleteFile()
        {
            string Path = @"G:\visualstudio\FileIOTextFile\FileIO1.txt";
            File.Delete(Path);
            Console.WriteLine("File deleted sucessfully");
        }
        public static void ReadAllText()
        {
            String path = @"G:\visualstudio\FileIOTextFile\FileIO.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }
        public static void Main(string[]args)
        {


            FileExist();
            ReadFile();
            CopyFile();
            DeleteFile();
            ReadAllText();
            
        }
    }
}
