using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.Files
{
    class Program
    {
        /*
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
          */
        /*
        string sourcePath = @"G:\Programação_Udemy\C#\TopicosEspeciais\Files\File_01.txt";
        StreamReader sr = null;

        try
        {
            sr = File.OpenText(sourcePath);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }                
        }
        catch (IOException e)
        {
            Console.WriteLine("An Error Accurred!");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
        }
        */
        /*
        string sourcePath = @"G:\Programação_Udemy\C#\TopicosEspeciais\Files\File_01.txt";

        try
        {
            using (StreamReader sr = File.OpenText(sourcePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An Error Accurred!");
            Console.WriteLine(e.Message);
        }
        */

        /*
        string sourcePath = @"G:\Programação_Udemy\C#\TopicosEspeciais\TopicosEspeciais\Files\File_01.txt";
        string targetPath = @"G:\Programação_Udemy\C#\TopicosEspeciais\TopicosEspeciais\Files\File_02.txt";

        try
        {
            // SALVAR EM OUTRO ARQUIVO COM LETRA MAIÚSCULA
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An Error Accurred!");
            Console.WriteLine(e.Message);
        }
        */

        /*
        string sourcePath = @"G:\Programação_Udemy\C#\TopicosEspeciais\TopicosEspeciais\myFolder";

        try
        {
            // PEGAR TODAS AS SUBPASTAS A PARTIR DA PASTA PAI
            IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS:");
            foreach (string s in folders)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            // PEGAR TODAS OS ARQUIVOS A PARTIR DA PASTA PAI
            var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES:");
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine();

            // CRIAR UMA PASTA
            Directory.CreateDirectory(sourcePath + "\\nova pasta - fernando");
            //Directory.CreateDirectory(sourcePath + @"\nova pasta - fernando");
            //Directory.CreateDirectory(@"G:\Programação_Udemy\C#\TopicosEspeciais\TopicosEspeciais\myFolder\fernando");
        }
        catch (IOException e)
        {
            Console.WriteLine("An Error Accurred!");
            Console.WriteLine(e.Message);
        }
        */

        /*
        string sourcePath = @"G:\Programação_Udemy\C#\TopicosEspeciais\TopicosEspeciais\myFolder\file1.txt";

        try
        {
            Console.WriteLine("DirectorySeparatorChar " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine(Path.GetDirectoryName(sourcePath));
            Console.WriteLine("GetFileName" + Path.GetFileName(sourcePath));
            Console.WriteLine("GetExtension " + Path.GetExtension(sourcePath));
            Console.WriteLine("GetFullPath " + Path.GetFullPath(sourcePath));
            Console.WriteLine("GetFileNameWithoutExtension " + Path.GetFileNameWithoutExtension(sourcePath));
            Console.WriteLine("GetTempPath " + Path.GetTempPath());
        }
        catch (IOException e)
        {
            Console.WriteLine("An Error Accurred!");
            Console.WriteLine(e.Message);
        }
        */
        /*
        string sourceFilePath = @"G:\Programação_Udemy\C#\TopicosEspeciais\TopicosEspeciais\myFolder\dados1.csv";

        try
        {
            string[] lines = File.ReadAllLines(sourceFilePath);

            string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
            string targetFolderPath = sourceFolderPath + @"\out";
            string targetFilePath = targetFolderPath + @"\dados2.csv";
            Console.WriteLine(targetFolderPath);
            Directory.CreateDirectory(targetFolderPath);

            using (StreamWriter sw = File.AppendText(targetFilePath))
            {
                foreach (string line in lines)
                {

                    string[] fields = line.Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[2]);

                    Product prod = new Product(name, price, quantity);

                    sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                }

            }
        }
        catch (IOException e)
        {

            Console.WriteLine("An Error Accurred With CSV!");
            Console.WriteLine(e.Message);
        }
        */
    }
}
