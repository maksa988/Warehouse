using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDHandler;
using Database.Config.Interfaces;
using Database.Exceptions;

namespace Database.Config
{
    
    public class Config : IConfig
    {
        private ConfigData _data;
        private string _path;

        public string Path
        {
            get
            {
                return this._data.Path;
            }
            set
            {
                this._data.Path = value;
            }
        }

        public string TableExt
        {
            get
            {
                return this._data.TableExtension;
            }
        }

        public string TablesDirectory
        {
            get
            {
                return this.Path + DirectoryHandler.DirectorySeparator.ToString() + this._data.TablesDirectory;
            }
        }

        public string TablesConfig
        {
            get
            {
                return this.TablesDir(this._data.TablesConfig);
            }
        }

        public string ConfigPath
        {
            get
            {
                return this._path;
            }
        }

        public Config()
        {
            this._data = new ConfigData();
        }

        public Config(string path)
        {
            this._init(path);
        }

        public Config(string path, string filename)
        {
            this._init(path, filename);
        }

        public void LoadFromFile(string filename)
        {
            using (FileHandler fHandler = new FileHandler(filename))
            {
                if (!fHandler.Empty())
                {
                    this._data = fHandler.Serializer.ReadJson(typeof(ConfigData)) as ConfigData;
                } else
                {
                    this._data = new ConfigData();
                    this._data.Path = this._path;
                }
            }
        }

        public string TablesDir(string path)
        {
            return DirectoryHandler.ValidateDirectoryPath(this.TablesDirectory) + path;
        }

        public string TablePath(string path)
        {
            return this.TablesDir(path + this.TableExt);
        }

        protected void _init(string path, string filename = "config.json")
        {
            this._data = new ConfigData();

            path = DirectoryHandler.ValidateDirectoryPath(path);

            if (!DirectoryHandler.Exists(path))
                throw new ConfigDirectoryNotFound(path);

            if (FileHandler.Exists(path + filename))
            {
                this._path = path + filename;
                this.LoadFromFile(path + filename);
            }
            else
            {
                this._data.Path = path;
                this._path = path + filename;

                using (FileHandler fHandler = new FileHandler(this._path))
                {
                    fHandler.Serializer.WriteJson(this._data);
                }
            }
        }

        protected void SaveData()
        {
            using (FileHandler fHandler = new FileHandler(this._path))
            {
                fHandler.Serializer.WriteJson(this._data);
            }
        }

        ~Config()
        {
            this.SaveData();
        }
    }
}
