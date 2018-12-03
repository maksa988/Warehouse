using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDHandler;
using System.Runtime.Serialization;
using Database.Table.Interfaces;

namespace Database.Table
{
    [Serializable]
    public abstract class AbstractTable : ITable
    {
        protected string _name;
        protected FileHandler _handler;
        protected bool _removeStatus = false;
        protected bool _dataLoaded = false;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public AbstractTable(string name, FileHandler handler)
        {
            this._name = name;
            this._handler = handler;
        }

        public AbstractTable(SerializationInfo info, StreamingContext context)
        {
            this._name = info.GetString("name");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", this._name);
        }

        public void SetHandler(FileHandler handler)
        {
            this._handler = handler;
        }

        public void Delete()
        {
            this._handler.DeleteFile();
            this._removeStatus = true;
        }

        abstract public void Truncate();
        abstract public void LoadData();
        abstract public void SaveData();
    }
}
