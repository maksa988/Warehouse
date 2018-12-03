using System.IO;
using FDHandler.Exceptions;

namespace FDHandler
{
    public class DirectoryHandler
    {
        private string _path;

        public string Path
        {
            get
            {
                return this._path;
            }
        }

        public DirectoryHandler(string path, bool create = true)
        {
            this._path = path;

            if (!this.Exists() && create)
                this.CreateDirectory();
        }

        public void CreateDirectory()
        {
            if (this.Exists())
                throw new DirectoryAlreadyExists(this._path);

            Directory.CreateDirectory(this._path);
        }

        public void DeleteDirectory()
        {
            this.CleanDirectory();
            Directory.Delete(this._path);
        }

        public bool Exists()
        {
            return Directory.Exists(this._path);
        }

        public static bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        public void CleanDirectory()
        {
            string[] files = Directory.GetFiles(this._path);

            for (int i = 0; i < files.Length; i++)
            {
                File.Delete(files[i]);
            }
        }

        public string GetPath(string filename)
        {
            return this._path + filename;
        }

        public override string ToString()
        {
            return this._path;
        }

        public static char DirectorySeparator
        {
            get
            {
                return System.IO.Path.DirectorySeparatorChar;
            }
        }

        public static string ValidateDirectoryPath(string path)
        {
            if (path.EndsWith(DirectorySeparator.ToString()))
                return path;

            return path + DirectorySeparator;
        }

    }
}
