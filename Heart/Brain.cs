using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Config;
using Database.Table;
using Database.Table.Interfaces;
using Database.Exceptions;
using Heart.Data;
using Heart.Interfaces;
using System.IO;
using Heart.Controllers;

namespace Heart
{
    public class Brain
    {
        private bool _initialized = false;

        public delegate void EventData(Type type, object data);
        public event EventData DataChanged;

        public SupplierController SupplierDataController;
        public GoodController GoodDataController;
        public CategoryController CategoryDataController;

        private ICommunication _ui;

        public ICommunication UI
        {
            get
            {
                return this._ui;
            }
        }

        public bool Initialized
        {
            get
            {
                return this._initialized;
            }
        }

        private MyDatabase _db;

        public Brain(ICommunication ui)
        {
            this._ui = ui;

            this.DataChanged += this._ui.DataChanged;
        }

        public void SaveSettings(string[] result)
        {
            if (Environment.CurrentDirectory + Path.DirectorySeparatorChar + "config.json" != result[0] && File.Exists(result[0]))
            {
                try
                {
                    if (!Directory.Exists(result[1]))
                        throw new Exception();

                    Config config = new Config(Environment.CurrentDirectory);
                    config.LoadFromFile(result[0]);
                    config.Path = result[1];

                    this._db = new MyDatabase(config);
                    this.FirstCreateTables();
                }
                catch
                {
                    this._ui.ErrorTrigger("Виникла невідома помилка при копіюванні конфігурацій");
                }
            } else
            {
                try
                {
                    if (!Directory.Exists(result[1]))
                        throw new Exception();

                    Config config = new Config(Environment.CurrentDirectory);
                    config.Path = result[1];

                    this._db = new MyDatabase(config);
                    this.FirstCreateTables();
                }
                catch
                {
                    this._ui.ErrorTrigger("Виникла невідома помилка при створювані налаштувань");
                }
            }

            this.Init();
            this._ui.StartProgram();
        }
       
        public void Init()
        {
            if (!File.Exists(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "config.json"))
                this._ui.FirstSettings();
            else
                this.SelfInit();
        }

        public void SelfInit()
        {
            if(this._db == null)
                this._db = new MyDatabase(new Config(Environment.CurrentDirectory));

            this.SupplierDataController = new SupplierController(this, this._db);
            this.GoodDataController = new GoodController(this, this._db);
            this.CategoryDataController = new CategoryController(this, this._db);

            this._initialized = true;
        }

        public void InitData()
        {
            this.SupplierDataController.DataChanged();
            this.GoodDataController.DataChanged();
            this.CategoryDataController.DataChanged();
        }

        private void FirstCreateTables()
        {
            this._db.CreateTable<Category>("Category");
            this._db.CreateTable<Good>("Good");
            this._db.CreateTable<Supplier>("Supplier");
        }

        public void ErrorMessage(string message)
        {
            this._ui.ErrorTrigger(message);
        }

        public void OnDataChanged(Type type, object data)
        {
            this.DataChanged(type, data);
        }
    }
}