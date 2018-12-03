using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDHandler;
using System.Runtime.Serialization;
using Database.Table.Interfaces;
using Database.Exceptions;

namespace Database.Table
{
    [Serializable]
    public class Table<T> : AbstractTable, ISerializable where T : ITableData<T>
    {
        private int _id = 0;
        private List<T> _data;

        public List<T> Data {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
                this.GetLastID();
            }
        }
        public delegate void EventData();
        public event EventData DataChanged;

        public T this[int index]
        {
            get
            {
                return this.Get(index);
            }
        }

        public int Count
        {
            get
            {
                return this._data.Count;
            }
        }

        public int LastID
        {
            get
            {
                return this._id;
            }
        }

        public int NextID
        {
            get
            {
                return this._id + 1;
            }
        }

        public Table(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this._data = new List<T>();
            this.DataChanged += this.SaveData;
            this.DataChanged += this.GetLastID;
        }

        public Table(string name, FileHandler handler) : base(name, handler)
        {
            this._data = new List<T>();
            this._dataLoaded = true;
            this.DataChanged += this.SaveData;
            this.DataChanged += this.GetLastID;
        }

        public void ReplaceData(List<T> data)
        {
            this._data = data;
            this.DataChanged();
        }

        public void AddData(List<T> data)
        {
            this._data.AddRange(data);
            this.DataChanged();
        }

        public void Insert(T data)
        {
            this._data.Add(data);
            this.GetLast().Id = this.NextID;
            this.DataChanged();
        }

        public void Insert(T data, int index)
        {
            this._data.Insert(index, data);
            this.GetLast().Id = this.NextID;
            this.DataChanged();
        }

        public void Remove(T data)
        {
            this._data.Remove(data);
            this.DataChanged();
        }

        public void Remove(int index)
        {
            this._data.RemoveAt(index);
            this.DataChanged();
        }

        public void RemoveID(int id)
        {
            T data = this.GetWhereID(id);

            if (data == null)
                throw new TableDataNotFound("ID: " + id);

            this.Remove(this.GetWhereID(id));
        }

        public T Get(int index)
        {
            return this._data[index];
        }

        public T GetLast()
        {
            return this._data[this.Count - 1];
        }

        public List<T> All()
        {
            return this.GetAll();
        }

        public List<T> GetDesc()
        {
            List<T> reverssedData = this._data;

            reverssedData.Reverse();

            return reverssedData;
        }

        public List<T> GetAll()
        {
            return this._data;
        }

        public List<T> GetWhere(object data, string parametr = null)
        {
            List<T> sResults = new List<T>();

            foreach (T tData in this._data)
            {
                if (tData.SearchData(data, parametr))
                {
                    sResults.Add(tData);
                }
            }

            return sResults;
        }

        public T GetWhereID(int id)
        {
            foreach(T tData in this._data)
            {
                if (tData.Id == id)
                    return tData;
            }

            return default(T);
        }

        public List<T> Sort(string parametr = "id")
        {
            List<T> sortedData = this._data;

            sortedData.Sort(new TableCompare<T>(parametr));

            return sortedData;
        }

        public List<T> SortAsc(string parametr = "id")
        {
            return this.Sort(parametr);
        }

        public List<T> SortDesc(string parametr = "id")
        {
            List<T> sortedData = this.Sort(parametr);

            sortedData.Reverse();

            return sortedData;
        }

        public void Update(int index, T data)
        {
            this._data[index] = data;
            this.DataChanged();
        }

        public void UpdateID(int id, T data)
        {
            int index = 0;

            foreach (T tData in this._data)
            {
                if (tData.Id == id)
                {
                    this.Update(index, data);
                    break;
                }

                index++;
            }
        }

        public override void Truncate()
        {
            this._data.Clear();
            this._handler.CleanFile();
            this.DataChanged();
        }

        public override void LoadData()
        {
            if(!this._dataLoaded)
            {
                if (this._handler.Empty())
                    this.Data = new List<T>();
                else
                    this.Data = this._handler.Serializer.ReadXML(typeof(List<T>)) as List<T>;
            }

            this._dataLoaded = true;
        }

        public override void SaveData()
        {
            if (!this._removeStatus)
            {
                this._handler.CleanFile();

                if (this._data.Count != 0)
                    this._handler.Serializer.WriteXML(this.Data);
            }
        }

        private void GetLastID()
        {
            if(this.Count != 0)
                this._id = this.GetLast().Id;
        }
    }
}
