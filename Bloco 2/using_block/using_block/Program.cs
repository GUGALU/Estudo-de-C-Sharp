using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace using_block
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\using_block\\text.txt";

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException err)
            {
                Console.WriteLine("Error");
                Console.WriteLine(err.Message);
            }
        }
    }
}
