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
                if (!Directory.Exists(path1))
                   workDirectory.CreateDirectory(path1);

                for (int i = 1; i <= 10; i++)
                {
                    string filepath = $@"c:\Otus\TestDir1\File{i}.txt";

                    if (File.Exists(filepath))
                        File.Delete(filepath);
                    
                    workFile.CreateFile(filepath);
                    workFile.WriteToFile(filepath, $"File{i}");
                    var task = workFile.AddedTextToFile(filepath);
                }



                if (!Directory.Exists(path2))
                   workDirectory.CreateDirectory(path2);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Что-то пошло не так! Ошибка - {ex.Message}");

            }

        }

    }


}
