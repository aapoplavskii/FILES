using System;
using System.IO;
using System.Text;

namespace Files
{
    public class WorkFile
    {
        public void CreateFileAndWriteInfoToFile(string path, string text)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.AutoFlush = true;
                streamWriter.Write(text, Encoding.UTF8);

            }


        }

        public async void AddedTextToFile(string path)
        {

            using (StreamWriter filestreamsync = new StreamWriter(path, true))
            {

                filestreamsync.AutoFlush = true;
                await filestreamsync.WriteAsync(Environment.NewLine + DateTime.Now.ToString());

            }

        }
        public string ReadFile(string path)
        {
            string sr = string.Empty;
            using (StreamReader streamReader = new StreamReader(path))
            {
                sr = streamReader.ReadToEnd();
            }

            return sr;

        }

    }
}
