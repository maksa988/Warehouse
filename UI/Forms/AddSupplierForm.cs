using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Interfaces;
using UI.Controllers;

namespace UI
{
    public partial class AddSupplierForm : Form, IForm
    {
        private SupplierController _controller;

        private bool _editMode = false;
        private int _supplierID = 0;
        
        public bool EditMode
        {
            get
            {
                return this._editMode;
            }

            set
            {
                this._editMode = value;
            }
        }

        public int DataID
        {
            get
            {
                return this._supplierID;
            }

            set
            {
                this._supplierID = value;
            }
        }

        public AddSupplierForm(SupplierController controller)
        {
            this._controller = controller;

            InitializeComponent();

            this.btnAddSupplier.Click += this._controller.AddFromForm;
        }

        public string[] GetResult()
        {
            string[] result = new string[2];

            result[0] = this.suppFirstname.Text;
            result[1] = this.suppSecondname.Text;

            return result;
        }

        public void ChangeMode(bool mode = true)
        {
            this.EditMode = mode;

            if (mode == true)
                this.btnAddSupplier.Text = "Зберегти";
            else
                this.btnAddSupplier.Text = "Додати";
        }

        public void SetResult(string[] result)
        {
            if (result[0] != string.Empty)
            {
                this.suppFirstname.Text = result[0];
                this.suppSecondname.Text = result[1];
            }
            else
            {
                this.suppFirstname.Clear();
                this.suppSecondname.Clear();
            }
        }

        private void AddSupplierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SetResult(new string[] { string.Empty });
            this.Hide();
            e.Cancel = true;
        }

        private void btnCancelAddSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
