using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Table;
using Database.Exceptions;
using Heart.Data;

namespace Heart.Controllers
{
    public class GoodController : Controller
    {
        private Table<Good> _table;

        public GoodController(Brain brain, MyDatabase db) : base(brain, db)
        {
            this._table = db.GetTable<Good>("Good");
        }

        public override void DataChanged(object data = null)
        {
            if (data == null)
                this._brain.OnDataChanged(typeof(Good), this._table.SortAsc());
            else
                this._brain.OnDataChanged(typeof(Good), data);

            this._brain.OnDataChanged(typeof(Category), this._brain.CategoryDataController.GetAll());
        }

        public override void Add(string[] data)
        {
            Good newData = new Good(data);

            this._table.Insert(newData);
            this.DataChanged();
        }

        public override void Edit(int id, string[] data)
        {
            Good good = this._table.GetWhereID(id);
            good.FromArray(data);

            this._table.UpdateID(id, good);
            this.DataChanged();
        }

        public override object Get(int id)
        {
            try
            {
                return this._table.GetWhereID(id);
            }
            catch (TableDataNotFound)
            {
                this.Error("Товар не знайдений");
                return null;
            }
        }

        public override object GetAll()
        {
            return this._table.GetAll();
        }

        public override void Remove(int id)
        {
            try
            {
                this._table.RemoveID(id);
                this.DataChanged();
            }
            catch (TableDataNotFound)
            {
                this.Error("Товар не знайдений");
            }
        }

        public override void Search(string text)
        {
            List<Good> results = this._table.GetWhere(text, "search");

            this.DataChanged(results);
        }

        public override void Sort(string param, int type = 0)
        {
            switch (type)
            {
                case 0:
                    this.DataChanged();
                    break;
                case 1:
                    this.DataChanged(this._table.SortAsc(param));
                    break;
                case 2:
                    this.DataChanged(this._table.SortDesc(param));
                    break;
            }
        }

        public int GetCountGoods(int id)
        {
            return this._table.GetWhere(id, "cat").Count;
        }

        public string GetCatName(Good good)
        {
            return this._brain.CategoryDataController.Get(good.CatId).ToString();
        }

        public List<Category> GetCategories()
        {
            return this._brain.CategoryDataController.GetAll() as List<Category>;
        }
    }
}
