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
    public partial class AddCategoryForm : Form, IForm
    {
        private CategoryController _controller;

        private bool _editMode = false;
        private int _catID = 0;

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
                return this._catID;
            }

            set
            {
                this._catID = value;
            }
        }

        public AddCategoryForm(CategoryController controller)
        {
            this._controller = controller;

            InitializeComponent();

            this.button1.Click += this._controller.AddFromForm;
        }

        public string[] GetResult()
        {
            return new string[] { this.textBox1.Text };
        }

        public void ChangeMode(bool mode = true)
        {
            this.EditMode = mode;

            if (mode == true)
                this.button1.Text = "Зберегти";
            else
                this.button1.Text = "Додати";
        }

        public void SetResult(string[] res)
        {
            this.textBox1.Text = res[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.Hide();
            e.Cancel = true;
        }
    }
}
