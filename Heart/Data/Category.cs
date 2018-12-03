using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Table.Interfaces;
using Heart.Interfaces;

namespace Heart.Data
{
    [Serializable]
    public class Category : AbstractData, ITableData<Category>
    {
        public Category() { }

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Category(string[] cat)
        {
            this.FromArray(cat);
        }

        public bool SearchData(object data, string parametr = null)
        {
            switch(parametr)
            {
                case "search":
                    if (this.Name.Contains(data.ToString()))
                        return true;
                    break;
            }
            return false;
        }

        public int SortCompare(Category other, string parametr = "id")
        {
            switch(parametr)
            {
                case "id":      return this.Id.CompareTo(other.Id);
                case "name":    return this.Name.CompareTo(other.Name);
            }

            return 0;
        }
    }
}