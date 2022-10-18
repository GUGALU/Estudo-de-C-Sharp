﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\Files\\text.txt";
            string targetPath = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\Files\\text2.txt";
            if(targetPath != @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\Files\\text2.txt")
            {
                File.Create(targetPath = @"C:\\Users\\Gustavo\\Desktop\\GU\\Code\\C#\\Bloco 2\\Files\\text2.txt");
            }

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter streamWriter = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        streamWriter.WriteLine(line.ToUpper());
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
