using System;
using System.Collections.Generic;
using Database.Exceptions;

namespace Database.Table
{
    [Serializable]
    public class Tables
    {
        private List<string> _keys;
        private List<AbstractTable> _data;

        public AbstractTable this[string name]
        {
            get
            {
                int Length = this._keys.Count;

                for (int i = 0; i < Length; i++)
                {
                    if (this._keys[i] == name)
                    {
                        return this._data[i];
                    }
                }

                throw new TableNotFound(name);
            }
        }

        public AbstractTable this[int index]
        {
            get
            {
                if (index >= this._data.Count)
                    throw new IndexOutOfRangeException();

                return this._data[index];
            }
        }

        public int Count
        {
            get
            {
                return this._data.Count;
            }
        }

        public bool Empty
        {
            get
            {
                if (this._data.Count == 0)
                    return true;

                return false;
            }
        }

        public Tables()
        {
            this._keys = new List<string>();
            this._data = new List<AbstractTable>();
        }
        
        public void Add(AbstractTable table)
        {
            this._keys.Add(table.Name);
            this._data.Add(table);
        }

        public void Add(string name, AbstractTable table)
        {
            this._keys.Add(name);
            this._data.Add(table);
        }

        public AbstractTable Get(string index)
        {
            return this[index];
        }

        public AbstractTable Delete()
        {
            int lastIndex = this._keys.Count - 1;

            return this.Delete(lastIndex);
        }

        public AbstractTable Delete(string name)
        {
            int index = this._keys.IndexOf(name);

            return this.Delete(index);
        }

        public AbstractTable Delete(int index)
        {
            if (index >= this.Count)
                throw new IndexOutOfRangeException();

            AbstractTable removedElement = this._data[index];

            this._keys.RemoveAt(index);
            this._data.RemoveAt(index);

            return removedElement;
        }

        public AbstractTable Delete(AbstractTable table)
        {
            if (!this._data.Contains(table))
                return null;

            int index = this._data.IndexOf(table);

            return this.Delete(index);
        }

        public bool Has(string name)
        {
            if (Empty)
                return false;
            
            try
            {
                return this[name] != null;
            }
            catch (TableNotFound)
            {
                return false;
            }
        }

        public bool Has(int index)
        {
            if (Empty)
                return false;
            
            try
            {
                return this[index] != null;
            } catch(IndexOutOfRangeException)
            {
                return false;
            }
        }

        public bool Has(AbstractTable table)
        {
            return _data.Contains(table);
        }
    }
}