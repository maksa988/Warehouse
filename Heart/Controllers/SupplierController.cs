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
    public class SupplierController : Controller
    {
        private Table<Supplier> _table;

        public SupplierController(Brain brain, MyDatabase db) : base(brain, db)
        {
            this._table = db.GetTable<Supplier>("Supplier");
        }

        public override void DataChanged(object data = null)
        {
            if (data == null)
                this._brain.OnDataChanged(typeof(Supplier), this._table.SortAsc());
            else
                this._brain.OnDataChanged(typeof(Supplier), data);
        }

        public override void Add(string[] data)
        {
            Supplier newData = new Supplier(data);

            this._table.Insert(newData);
            this.DataChanged();
        }

        public override void Edit(int id, string[] data)
        {
            Supplier supplier = this._table.GetWhereID(id);
            supplier.FromArray(data);

            this._table.UpdateID(id, supplier);
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
                this.Error("Постачальник не знайдений");
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
                this.Error("Постачальник не знайдений");
            }
        }

        public override void Search(string text)
        {
            List<Supplier> results = this._table.GetWhere(text, "search");

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
