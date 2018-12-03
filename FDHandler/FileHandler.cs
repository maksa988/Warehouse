using System;
using System.Text;
using System.IO;
using FDHandler.Serialization;

namespace FDHandler
{
    public class FileHandler : IDisposable
    {
        private string _path;
        private FileStream _fs;
        private Serializer _serializer;
        
        public string Path
        {
            get
            {
                return this._path;
            }
        }

        public Serializer Serializer
        {
            get
            {
                return this._serializer;
            }
        }

        public FileHandler(string path, bool create = true)
        {
            this._path = path;

            if (create)
            {
                this._fs = new FileStream(this._path, FileMode.OpenOrCreate);
            }
            else
            {
                if (!this.Exists())
                    throw new FileNotFoundException(this._path + ": File not exists");

                this._fs = new FileStream(this._path, FileMode.Open);
            }

            this._serializer = new Serializer(this._fs);
        }

        public void DeleteFile()
        {
            this.Dispose();
            File.Delete(this._path);
        }

        public bool Exists()
        {
            return File.Exists(this._path);
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public void CleanFile()
        {
            this._fs.Position = 0;
            this._fs.SetLength(0);
        }

        public bool Empty()
        {  
            return this.ReadText() == String.Empty;
        }

        public void Write(byte[] bytes)
        {
            this._fs.Write(bytes, 0, bytes.Length);
        }

        public void WriteText(string content)
        {
            byte[] bytes = System.Text.Encoding.Default.GetBytes(content);

            this.Write(bytes);
        }

        public void WriteLines(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                this.WriteText(data[i] + "\n");
            }
        }
        
        public byte[] Read()
        {
            this._fs.Position = 0;

            byte[] bytes = new byte[_fs.Length];

            this._fs.Read(bytes, 0, bytes.Length);

            return bytes;
        }

        public string ReadText()
        {
            byte[] bytes = this.Read();

            return System.Text.Encoding.Default.GetString(bytes);
        }
        
        public virtual void Dispose()
        {
            this._fs.Close();
        }

        ~FileHandler()
        {
            this.Dispose();
        }
    }
}
