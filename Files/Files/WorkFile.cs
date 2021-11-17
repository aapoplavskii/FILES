using System.IO;

namespace Files
{
    public class WorkFile
    {
        public void CreateFile(string path)
        {
            File.Create(path);

        }

        public void WriteIntoFile(string path, string text)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.AutoFlush = true;
                streamWriter.Write(text);
                streamWriter.Close();
            }

        }

    }
}
