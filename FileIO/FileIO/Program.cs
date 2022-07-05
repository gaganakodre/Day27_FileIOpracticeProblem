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
        
        public static void Main(string[]args)
        {


            FileExist();
            
        }
    }
}
