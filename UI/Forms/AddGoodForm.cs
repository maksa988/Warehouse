using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heart.Data;
using UI.Interfaces;
using UI.Controllers;

namespace UI
{
    public partial class AddGoodForm : Form, IForm
    {
        private GoodController _controller;
        private List<Category> _categories;

        private bool _editMode = false;
        private int _goodID = 0;

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
                return this._goodID;
            }

            set
            {
                this._goodID = value;
            }
        }

        public AddGoodForm(GoodController controller)
        {
            this._controller = controller;

            InitializeComponent();

            this.btnAddGood.Click += this._controller.AddFromForm;
        }

        public void SetCategories(List<Category> data)
        {
            this._categories = data;
            this.cboxCategory.Items.Clear();

            foreach(Category tData in data)
            {
                this.cboxCategory.Items.Add(tData.ToString());
            }
        }

        public string[] GetResult()
        {
            string[] result = new string[5];

            result[0] = this.txtGoodName.Text;
            result[1] = this.txtGoodBrand.Text;
            result[2] = this.nmrcGoodPrice.Text;
            result[4] = this.nmrcGoodCount.Text;

            foreach(Category tData in this._categories)
            {
                if(tData.ToString() == this.cboxCategory.Text)
                {
                    result[3] = tData.Id.ToString();
                    break;
                }
            }

            return result;
        }

        public void ChangeMode(bool mode = true)
        {
            this.EditMode = mode;

            if (mode == true)
                this.btnAddGood.Text = "Зберегти";
            else
                this.btnAddGood.Text = "Додати";
        }

        public void SetResult(string[] result)
        {
            if (result[0] != string.Empty)
            {
                this.txtGoodName.Text = result[0];
                this.txtGoodBrand.Text = result[1];
                this.nmrcGoodPrice.Text = result[2];
                this.cboxCategory.Text = result[3];
                this.nmrcGoodCount.Text = result[4];

                int index = 0;
                foreach (Category tData in this._categories)
                {
                    if (tData.Id == int.Parse(result[3]))
                    {
                        this.cboxCategory.SelectedIndex = index;
                        break;
                    }
                    index++;
                }
            } else
            {
                this.txtGoodName.Clear();
                this.txtGoodBrand.Clear();
                this.nmrcGoodPrice.Value = 0;
                this.cboxCategory.SelectedIndex = 0;
                this.nmrcGoodCount.Value = 0;
            }
        }

        private void AddGoodForm_Resize(object sender, EventArgs e)
        {
            this.Width = 303;
            this.Height = 345;
        }

        private void AddGoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SetResult(new string[] { string.Empty });
            this.Hide();
            e.Cancel = true;
        }

        private void btnCancelAddGood_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
