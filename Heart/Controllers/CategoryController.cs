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
    public class CategoryController : Controller
    {
        private Table<Category> _table;

        public CategoryController(Brain brain, MyDatabase db) : base(brain, db)
        {
            this._table = db.GetTable<Category>("Category");
        }

        public override void DataChanged(object data = null)
        {
            if (data == null)
                this._brain.OnDataChanged(typeof(Category), this._table.SortAsc());
            else
                this._brain.OnDataChanged(typeof(Category), data);
        }

        public override void Add(string[] data)
        {
            Category newData = new Category(data);

            this._table.Insert(newData);
            this.DataChanged();
        }

        public override void Edit(int id, string[] data)
        {
            Category cat = this._table.GetWhereID(id);
            cat.FromArray(data);

            this._table.UpdateID(id, cat);
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
                this.Error("Категорія не знайдена");
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
                this.Error("Категорія не знайдена");
            }
        }

        public override void Search(string text)
        {
            List<Category> results = this._table.GetWhere(text, "search");

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
    }
}
