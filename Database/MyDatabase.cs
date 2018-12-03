using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDHandler;
using Database.Table;
using Database.Table.Interfaces;

namespace Database
{
    public class MyDatabase : Core
    {
        public MyDatabase(Config.Config config) : base(config) { }

        public MyDatabase(string path) : base(path) { }

        public Table<T> CreateTable<T>(string name) where T : ITableData<T>
        {
            if (!this._tables.Has(name))
                this._tables.Add(name, new Table<T>(name, new FileHandler(this._config.TablePath(name))));

            return this.GetTable<T>(name);
        }

        public Table<T> CreateTable<T>(string name, T data) where T : ITableData<T>, new()
        {
            this.CreateTable<T>(name).Insert(data);
            
            return this.GetTable<T>(name);
        }

        public Table<T> GetTable<T>(string name) where T : ITableData<T>
        {
            Table<T> table = this._tables[name] as Table<T>;
            return this._tables[name] as Table<T>;
        }

        public AbstractTable GetTable(string name)
        {
            return this._tables[name];
        }

        public void DeleteTable(string name)
        {
            this._tables.Delete(name).Delete();
        }
    }
}
