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
            string CopyPath = @"G:\visualstudio\FileIOTextFile\FileIO1.txt";//here i will get a exception buz file is already copied
            File.Copy(path, CopyPath);
        }
        public static void DeleteFile()
        {
            string Path = @"G:\visualstudio\FileIOTextFile\FileIO1.txt";
            File.Delete(Path);
            Console.WriteLine("File deleted sucessfully");
        }
        public static void ReadAllText()//it will raed all the text in the files
        {
            String path = @"G:\visualstudio\FileIOTextFile\FileIO.txt";
            string lines;
            lines = File.ReadAllText(path);//it will return the string
            Console.WriteLine(lines);
            
        }
        public static void ReadStreamReader()
        {
            String path= @"G:\visualstudio\FileIOTextFile\FileIO.txt";
            using(StreamReader read = File.OpenText(path))
            {
                String s = "";
                while((s=read.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();//it will wait for a key press
        }
        public static void WriteUsingStreamWriter()
        {
            string path = @"G:\visualstudio\FileIOTextFile\FileIO1.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello world.net class");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }

        public static void Main(string[]args)
        {


            FileExist();
            ReadFile();
            CopyFile();
            DeleteFile();
            ReadAllText();
            WriteUsingStreamWriter();
            ReadStreamReader();
            ReadFile();

            
        }
    }
}
