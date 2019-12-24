using System;
using System.IO;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // sintaxe @ evita colocar duas barras seguidas
            string sourcePath = @"G:\Programação_Udemy\C#\TopicosEspeciais\Files\File_01.txt";
            string targetPath = @"G:\Programação_Udemy\C#\TopicosEspeciais\Files\File_02.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
