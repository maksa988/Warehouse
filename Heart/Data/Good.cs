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
    public class Good : AbstractData, ITableData<Good>
    {
        public string Brand { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public int CatId { get; set; }

        public Good() { }

        public Good(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Good(string name)
        {
            this.Name = name;
        }

        public Good(string[] good)
        {
            this.FromArray(good);
        }

        public bool SearchData(object data, string parametr = null)
        {
            switch (parametr)
            {
                case "search":
                    if (this.Name.Contains(data.ToString()))
                        return true;
                    break;
                case "cat":
                    if (this.CatId == int.Parse(data.ToString()))
                        return true;
                    break;
            }
            return false;
        }

        public int SortCompare(Good other, string parametr = "id")
        {
            switch (parametr)
            {
                case "id": return this.Id.CompareTo(other.Id);
                case "name": return this.Name.CompareTo(other.Name);
                case "brand": return this.Brand.CompareTo(other.Brand);
                case "price": return this.Price.CompareTo(other.Price);
                case "count": return this.Count.CompareTo(other.Count);
            }

            return 0;
        }

        public override void FromArray(string[] arr)
        {
            this.Name = arr[0];
            this.Brand = arr[1];
            this.Price = float.Parse(arr[2]);
            this.CatId = int.Parse(arr[3]);
            this.Count = int.Parse(arr[4]);
        }

        public override string[] ToArray()
        {
            return new string[] {
                this.Name,
                this.Brand,
                this.Price.ToString(),
                this.CatId.ToString(),
                this.Count.ToString(),
            };
        }
    }
}
