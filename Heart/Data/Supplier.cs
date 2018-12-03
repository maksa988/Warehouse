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
    public class Supplier : AbstractData, ITableData<Supplier>
    {
        public string SecondName { get; set; }

        public Supplier() { }

        public Supplier(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Supplier(string name)
        {
            this.Name = name;
        }

        public Supplier(string[] supplier)
        {
            this.FromArray(supplier);
        }

        public bool SearchData(object data, string parametr = null)
        {
            switch (parametr)
            {
                case "search":
                    if (this.Name.Contains(data.ToString()))
                        return true;
                    break;
            }
            return false;
        }

        public int SortCompare(Supplier other, string parametr = "id")
        {
            switch (parametr)
            {
                case "id": return this.Id.CompareTo(other.Id);
                case "name": return this.Name.CompareTo(other.Name);
            }

            return 0;
        }

        public override void FromArray(string[] arr)
        {
            this.Name = arr[0];
            this.SecondName = arr[1];
        }

        public override string[] ToArray()
        {
            return new string[] {
                this.Name,
                this.SecondName
            };
        }
    }
}
