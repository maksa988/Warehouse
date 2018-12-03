using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Table;
using Heart.Interfaces;

namespace Heart.Controllers
{
    public abstract class Controller
    {
        protected MyDatabase _db;
        protected Brain _brain;

        public Brain Brain
        {
            get
            {
                return this._brain;
            }
        }

        public Controller(Brain brain, MyDatabase db)
        {
            this._brain = brain;
            this._db = db;
        }

        public abstract void DataChanged(object data = null);

        public abstract void Add(string[] data);
        public abstract void Remove(int id);
        public abstract object Get(int id);
        public abstract object GetAll();
        public abstract void Edit(int id, string[] data);
        public abstract void Search(string text);
        public abstract void Sort(string param, int type = 0);

        public virtual void Error(string message)
        {
            this._brain.ErrorMessage(message);
        }
    }
}
