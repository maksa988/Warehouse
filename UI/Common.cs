using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heart;
using Heart.Interfaces;
using Heart.Data;
using UI.Controllers;

namespace UI
{
    public class Common : ICommunication
    {
        private Brain _brain;

        public Brain Brain
        {
            get
            {
                return this._brain;
            }
        }

        private SupplierController _supplierController;
        private GoodController _goodController;
        private CategoryController _categoryController;

        public SupplierController SupplierController
        {
            get
            {
                return this._supplierController;
            }
        }

        public GoodController GoodController
        {
            get
            {
                return this._goodController;
            }
        }

        public CategoryController CategoryController
        {
            get
            {
                return this._categoryController;
            }
        }

        protected MainForm MainForm;
        protected FirstSettingsForm FirstSettingsForm;

        protected Form StartForm;

        public Common()
        {
            _initForms();

            this.StartForm = this.MainForm;

            this._brain = new Brain(this);

            this._brain.Init();

            if(this._brain.Initialized)
            {
                this.SupplierController.DataController = this._brain.SupplierDataController;
                this.CategoryController.DataController = this._brain.CategoryDataController;
                this.GoodController.DataController = this._brain.GoodDataController;

                this._brain.InitData();
            }
        }

        public void FirstSettings()
        {
            this.StartForm = this.FirstSettingsForm;
        }

        public void StartProgram()
        {
            System.Windows.Forms.Application.Restart();
            System.Environment.Exit(1);
        }

        public void ClosePorgram()
        {
            this.Close();
            this.FirstSettingsForm.Close();
        }

        public void SaveSettingsClick(object sender, EventArgs e)
        {
            this._brain.SaveSettings(this.FirstSettingsForm.GetResult());
        }

        public void DataChanged(Type type, object data)
        {
            if (type == typeof(Category))
            {
                this._categoryController.Draw(data);
            }
            else if (type == typeof(Supplier))
            {
                this._supplierController.Draw(data);
            }
            else if (type == typeof(Good))
            {
                this._goodController.Draw(data);
            }
        }

        public void ErrorTrigger(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Form GetMainForm()
        {
            return this.StartForm;
        }

        public void Close()
        {
            this.StartForm.Close();
        }
        
        private void _initForms()
        {
            this._supplierController = new SupplierController();
            this._categoryController = new CategoryController();
            this._goodController = new GoodController();

            this.MainForm = new MainForm(this);
            this.FirstSettingsForm = new FirstSettingsForm(this);

            this._supplierController.MainForm = this.MainForm;
            this._categoryController.MainForm = this.MainForm;
            this._goodController.MainForm = this.MainForm;
        }
    }
}
