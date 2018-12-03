using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FDHandler;
using Database.Table;
using Database.Table.Interfaces;

namespace Database
{
    public abstract class Core
    {
        protected Config.Config _config;
        protected Tables _tables;

        public Tables Tables
        {
            get
            {
                return this._tables;
            }
        }

        public Core(Config.Config config)
        {
            this._config = config;
            this._init();
        }

        public Core(string path)
        {
            this._config = new Config.Config(path);
            this._init();
        }

        public Core(string path, string dbname)
        {
            this._config = new Config.Config(path + DirectoryHandler.DirectorySeparator + dbname);
            this._init();
        }

        protected void _init()
        {
            if (!DirectoryHandler.Exists(this._config.TablesDirectory))
                new DirectoryHandler(this._config.TablesDirectory);

            this._loadTables();
        }

        protected void _loadTables()
        {
            using (FileHandler fileHandler = new FileHandler(this._config.TablesConfig))
            {
                if (fileHandler.Empty())
                    this._tables = new Tables();
                else
                {
                    this._tables = fileHandler.Serializer.ReadBin(typeof(Tables)) as Tables;

                    for (int i = 0; i < this._tables.Count; i++)
                    {
                        string path = this._config.TablePath(this._tables[i].Name);
                        bool res = FileHandler.Exists(this._config.TablePath(this._tables[i].Name));
                        if (!FileHandler.Exists(this._config.TablePath(this._tables[i].Name)))
                        {
                            this._tables.Delete(i);
                            continue;
                        }

                        this._tables[i].SetHandler(new FileHandler(this._config.TablePath(this._tables[i].Name)));
                        this._tables[i].LoadData();
                    }
                }
                
            }
        }

        protected void SaveData()
        {
            using (FileHandler fileHandler = new FileHandler(this._config.TablesConfig))
            {
                fileHandler.Serializer.WriteBin(this._tables);
            }
        }

        ~Core()
        {
            this.SaveData();
        }
    }
}
