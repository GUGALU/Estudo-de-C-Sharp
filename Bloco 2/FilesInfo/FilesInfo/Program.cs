using System;
using System.IO;

namespace FilesInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\FilesInfo\\File.txt";

            string targetPath = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\FilesInfo\\File2.txt";

            if (File.Exists(targetPath = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\FilesInfo\\File2.txt"))
            {
                File.Delete(targetPath);
            }

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException erro)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(erro.Message);
            }

            string path = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\FilesInfo\\FileStream.txt";

            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream);
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException erro)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(erro.Message);
            }
            finally
            {
                if(fileStream != null) fileStream.Close();
                if(streamReader != null) streamReader.Close();
            }
        }
    }
}
