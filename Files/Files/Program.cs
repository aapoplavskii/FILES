using System;
using System.IO;

namespace Files
{
    class Program
    {

        static void Main(string[] args)
        {
            string path1 = @"c:\Otus\TestDir1";
            string path2 = @"c:\Otus\TestDir2";

            WorkDirectory workDirectory = new WorkDirectory();
            WorkFile workFile = new WorkFile();
            

            try
            {
                workDirectory.CreateDirectory(path1);
                workDirectory.CreateDirectory(path2);

                CreateAndWriteFile(path1, workFile);
                CreateAndWriteFile(path2, workFile);

                Console.WriteLine($"Данные по каталогу {Path.GetFullPath(path1)}:");
                Console.WriteLine("");
                WriteConsoleInfoForFile(path1, workFile);

                Console.WriteLine($"Данные по каталогу {Path.GetFullPath(path2)}:");
                Console.WriteLine("");
                WriteConsoleInfoForFile(path2, workFile);

            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Что-то пошло не так! Ошибка - {ex.Message}");

            }

        }

        static void WriteConsoleInfoForFile(string path, WorkFile workFile)
        {

            var filesInDirectory = Directory.GetFiles(path);

            foreach (var filepath in filesInDirectory)
            {
                var readintofile = workFile.ReadFile(filepath);
                Console.WriteLine($"Файл {Path.GetFileName(filepath)}: ");
                Console.WriteLine(readintofile);
                Console.WriteLine("");
            }


        }
        
        static void CreateAndWriteFile(string path, WorkFile workFile)
        {

            for (int i = 1; i <= 10; i++)
            {
                string filepath = $@"{path}\File{i}.txt";

                if (File.Exists(filepath))
                    File.Delete(filepath);
                               
                workFile.CreateFileAndWriteInfoToFile(filepath, $"File{i}");
                workFile.AddedTextToFile(filepath);
            }

        }

    }


}
