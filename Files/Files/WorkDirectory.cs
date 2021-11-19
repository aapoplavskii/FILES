using System.IO;

namespace Files
{
    public class WorkDirectory
    {
        public void CreateDirectory(string path)
        {

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

        }

    }
}
