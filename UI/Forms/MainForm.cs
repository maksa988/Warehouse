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

namespace UI
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private Common _common;

        private int goodNameSortMethod = 0;
        private int goodBrandSortMethod = 0;
        private int goodCountSortMethod = 0;

        private int supplierNameSortMethod = 0;
        private int supplierSecondNameSortMethod = 0;

        public MainForm(Common common)
        {
            this._common = common;
            
            InitializeComponent();

            this.btnAddCategory.Click += this._common.CategoryController.ShowAddForm;
            this.btnAddGood.Click += this._common.GoodController.ShowAddForm;
            this.btnAddSupplier.Click += this._common.SupplierController.ShowAddForm;
            this.searchCatBox.KeyUp += this._common.CategoryController.Search;
            this.searchGoodBox.KeyUp += this._common.GoodController.Search;
            this.searchSupplierBox.KeyUp += this._common.SupplierController.Search;
        }

        #region Drawing Data

        public void DrawCategoriesList(List<Category> data)
        {
            int yPosition = 3;

            this.tblCatContent.Controls.Clear();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            for (int i = 0; i < data.Count; i++)
            {
            
                Label catId = new Label();
                catId.Text = data[i].Id + "";
                catId.Location = new System.Drawing.Point(8, yPosition);
                catId.AutoSize = true;
                this.tblCatContent.Controls.Add(catId);

                Label catName = new Label();
                catName.Text = data[i].Name;
                catName.Location = new System.Drawing.Point(34, yPosition);
                this.tblCatContent.Controls.Add(catName);

                Label catGoodsCount = new Label();
                catGoodsCount.Text = this._common.CategoryController.GetCountGoods(data[i].Id).ToString();
                catGoodsCount.Location = new System.Drawing.Point(291, yPosition);
                this.tblCatContent.Controls.Add(catGoodsCount);

                Button catOptionsEdit = new Button();
                catOptionsEdit.Text = "Р";
                catOptionsEdit.Width = 20;
                Button catOptionsRemove = new Button();
                catOptionsRemove.Text = "В";
                catOptionsRemove.Width = 20;

                catOptionsEdit.Tag = data[i].Id;
                catOptionsRemove.Tag = data[i].Id;

                catOptionsEdit.Click += new System.EventHandler(this._common.CategoryController.EditBtnClick);
                catOptionsRemove.Click += new System.EventHandler(this._common.CategoryController.RemoveBtnClick);

                catOptionsEdit.Location = new System.Drawing.Point(473, yPosition);
                catOptionsRemove.Location = new System.Drawing.Point(495, yPosition);
                this.tblCatContent.Controls.Add(catOptionsEdit);
                this.tblCatContent.Controls.Add(catOptionsRemove);

                yPosition += 24;
            }
        }

        public void DrawGoodsList(List<Good> data)
        {
            int yPosition = 3;

            this.tblGoodContent.Controls.Clear();

            for (int i = 0; i < data.Count; i++)
            {

                Label goodId = new Label();
                goodId.Text = data[i].Id + "";
                goodId.Location = new System.Drawing.Point(8, yPosition);
                goodId.AutoSize = true;
                this.tblGoodContent.Controls.Add(goodId);

                Label goodName = new Label();
                goodName.Text = data[i].Name;
                goodName.Location = new System.Drawing.Point(34, yPosition);
                goodName.Tag = data[i].Id;
                goodName.DoubleClick += this._common.GoodController.DbClickGoodName;
                this.tblGoodContent.Controls.Add(goodName);

                Label goodCategory = new Label();
                goodCategory.Text = this._common.CategoryController.GetName(data[i].CatId);
                goodCategory.Location = new System.Drawing.Point(194, yPosition);
                this.tblGoodContent.Controls.Add(goodCategory);

                Label goodBrand = new Label();
                goodBrand.Text = data[i].Brand;
                goodBrand.Location = new System.Drawing.Point(333, yPosition);
                this.tblGoodContent.Controls.Add(goodBrand);

                Label goodCount = new Label();
                goodCount.Text = data[i].Count.ToString();
                goodCount.Location = new System.Drawing.Point(454, yPosition);
                this.tblGoodContent.Controls.Add(goodCount);

                Button goodOptionsEdit = new Button();
                goodOptionsEdit.Text = "Р";
                goodOptionsEdit.Width = 20;
                Button goodOptionsRemove = new Button();
                goodOptionsRemove.Text = "В";
                goodOptionsRemove.Width = 20;

                goodOptionsEdit.Tag = data[i].Id;
                goodOptionsRemove.Tag = data[i].Id;

                goodOptionsEdit.Click += new System.EventHandler(this._common.GoodController.EditBtnClick);
                goodOptionsRemove.Click += new System.EventHandler(this._common.GoodController.RemoveBtnClick);

                goodOptionsEdit.Location = new System.Drawing.Point(555, yPosition);
                goodOptionsRemove.Location = new System.Drawing.Point(576, yPosition);
                this.tblGoodContent.Controls.Add(goodOptionsEdit);
                this.tblGoodContent.Controls.Add(goodOptionsRemove);

                yPosition += 24;
            }
        }

        public void DrawSuppliersList(List<Supplier> data)
        {
            int yPosition = 3;

            this.tblSupplierContent.Controls.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                Label suppId = new Label();
                suppId.Text = data[i].Id + "";
                suppId.Location = new System.Drawing.Point(8, yPosition);
                suppId.AutoSize = true;
                this.tblSupplierContent.Controls.Add(suppId);

                Label suppName = new Label();
                suppName.Text = data[i].Name;
                suppName.Location = new System.Drawing.Point(34, yPosition);
                this.tblSupplierContent.Controls.Add(suppName);

                Label suppSecondName = new Label();
                suppSecondName.Text = data[i].SecondName;
                suppSecondName.Location = new System.Drawing.Point(254, yPosition);
                this.tblSupplierContent.Controls.Add(suppSecondName);

                Button suppOptionsEdit = new Button();
                suppOptionsEdit.Text = "Р";
                suppOptionsEdit.Width = 20;
                Button suppOptionsRemove = new Button();
                suppOptionsRemove.Text = "В";
                suppOptionsRemove.Width = 20;

                suppOptionsEdit.Tag = data[i].Id;
                suppOptionsRemove.Tag = data[i].Id;

                suppOptionsEdit.Click += new System.EventHandler(this._common.SupplierController.EditBtnClick);
                suppOptionsRemove.Click += new System.EventHandler(this._common.SupplierController.RemoveBtnClick);

                suppOptionsEdit.Location = new System.Drawing.Point(541, yPosition);
                suppOptionsRemove.Location = new System.Drawing.Point(562, yPosition);
                this.tblSupplierContent.Controls.Add(suppOptionsEdit);
                this.tblSupplierContent.Controls.Add(suppOptionsRemove);

                yPosition += 24;
            }
        }

        #endregion

        #region Search Placeholder

        private void searchRemoveText(object sender, EventArgs e)
        {
            this.searchCatBox.Text = String.Empty;
            this.searchGoodBox.Text = String.Empty;
            this.searchSupplierBox.Text = String.Empty;
        }

        private void searchAddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.searchCatBox.Text))
                this.searchCatBox.Text = "Пошук...";

            if (String.IsNullOrWhiteSpace(this.searchGoodBox.Text))
                this.searchGoodBox.Text = "Пошук...";

            if (String.IsNullOrWhiteSpace(this.searchSupplierBox.Text))
                this.searchSupplierBox.Text = "Пошук...";
        }

        #endregion

        #region Sort

        private void tblGoodName_Click(object sender, EventArgs e)
        {
            switch(this.goodNameSortMethod)
            {
                case 0:
                    this.GoodsCleanOtherSort();
                    this.tblGoodName.Text = "Назва ↓";
                    this._common.GoodController.Sort("name", 1);
                    this.goodNameSortMethod = 1;
                    break;
                case 1:
                    this.tblGoodName.Text = "Назва ↑";
                    this._common.GoodController.Sort("name", 2);
                    this.goodNameSortMethod = 2;
                    break;
                case 2:
                    this.tblGoodName.Text = "Назва";
                    this._common.GoodController.Sort("id", 1);
                    this.goodNameSortMethod = 0;
                    break;
            }
        }

        private void tblGoodBrand_Click(object sender, EventArgs e)
        {
            switch (this.goodBrandSortMethod)
            {
                case 0:
                    this.GoodsCleanOtherSort();
                    this.tblGoodBrand.Text = "Бренд ↓";
                    this._common.GoodController.Sort("brand", 1);
                    this.goodBrandSortMethod = 1;
                    break;
                case 1:
                    this.tblGoodBrand.Text = "Бренд ↑";
                    this._common.GoodController.Sort("brand", 2);
                    this.goodBrandSortMethod = 2;
                    break;
                case 2:
                    this.tblGoodBrand.Text = "Бренд";
                    this._common.GoodController.Sort("brand", 1);
                    this.goodBrandSortMethod = 0;
                    break;
            }
        }

        private void tblGoodCount_Click(object sender, EventArgs e)
        {
            switch (this.goodCountSortMethod)
            {
                case 0:
                    this.GoodsCleanOtherSort();
                    this.tblGoodCount.Text = "Кількість ↓";
                    this._common.GoodController.Sort("count", 1);
                    this.goodCountSortMethod = 1;
                    break;
                case 1:
                    this.tblGoodCount.Text = "Кількість ↑";
                    this._common.GoodController.Sort("count", 2);
                    this.goodCountSortMethod = 2;
                    break;
                case 2:
                    this.tblGoodCount.Text = "Кількість";
                    this._common.GoodController.Sort("count", 1);
                    this.goodCountSortMethod = 0;
                    break;
            }
        }

        private void tblSupplierName_Click(object sender, EventArgs e)
        {
            switch (this.supplierNameSortMethod)
            {
                case 0:
                    this.SupplierCleanOtherSort();
                    this.tblSupplierName.Text = "Імя ↓";
                    this._common.SupplierController.Sort("name", 1);
                    this.supplierNameSortMethod = 1;
                    break;
                case 1:
                    this.tblSupplierName.Text = "Імя ↑";
                    this._common.SupplierController.Sort("name", 2);
                    this.supplierNameSortMethod = 2;
                    break;
                case 2:
                    this.tblSupplierName.Text = "Імя";
                    this._common.SupplierController.Sort("id", 1);
                    this.supplierNameSortMethod = 0;
                    break;
            }
        }

        private void tblSupplierSecondName_Click(object sender, EventArgs e)
        {
            switch (this.supplierSecondNameSortMethod)
            {
                case 0:
                    this.SupplierCleanOtherSort();
                    this.tblSupplierSecondName.Text = "Прізвище ↓";
                    this._common.SupplierController.Sort("second", 1);
                    this.supplierSecondNameSortMethod = 1;
                    break;
                case 1:
                    this.tblSupplierSecondName.Text = "Прізвище ↑";
                    this._common.SupplierController.Sort("second", 2);
                    this.supplierSecondNameSortMethod = 2;
                    break;
                case 2:
                    this.tblSupplierSecondName.Text = "Прізвище";
                    this._common.SupplierController.Sort("id", 1);
                    this.supplierSecondNameSortMethod = 0;
                    break;
            }
        }

        private void SupplierCleanOtherSort()
        {
            this.supplierNameSortMethod = 0;
            this.supplierSecondNameSortMethod = 0;
            this.tblGoodName.Text = "Імя";
            this.tblSupplierSecondName.Text = "Прізвище";
        }

        private void GoodsCleanOtherSort()
        {
            this.goodNameSortMethod = 0;
            this.goodBrandSortMethod = 0;
            this.goodCountSortMethod = 0;
            this.tblGoodName.Text = "Назва";
            this.tblGoodBrand.Text = "Бренд";
            this.tblGoodCount.Text = "Кількість";
        }

        #endregion
    }
}
