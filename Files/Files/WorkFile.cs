using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class WorkFile
    {
        public void CreateFile(string path)
        {
            using (File.Create(path));
            
        }

        public void WriteToFile(string path, string text)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.AutoFlush = true;
                streamWriter.Write(text, Encoding.UTF8);
                
            }

            
        }

        public async Task AddedTextToFile(string path)
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
