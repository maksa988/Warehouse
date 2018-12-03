namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.catTab = new System.Windows.Forms.TabPage();
            this.searchCatBox = new System.Windows.Forms.TextBox();
            this.tblCat = new System.Windows.Forms.Panel();
            this.tblCatContent = new System.Windows.Forms.Panel();
            this.tblCategoryID = new System.Windows.Forms.Label();
            this.tblCategoryOptions = new System.Windows.Forms.Label();
            this.tblCategoryName = new System.Windows.Forms.Label();
            this.tblCategoryGoods = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.goodsTab = new System.Windows.Forms.TabPage();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.tblGood = new System.Windows.Forms.Panel();
            this.tblGoodCategory = new System.Windows.Forms.Label();
            this.tblGoodCount = new System.Windows.Forms.Label();
            this.tblGoodContent = new System.Windows.Forms.Panel();
            this.tblGoodID = new System.Windows.Forms.Label();
            this.tblGoodOptions = new System.Windows.Forms.Label();
            this.tblGoodName = new System.Windows.Forms.Label();
            this.tblGoodBrand = new System.Windows.Forms.Label();
            this.searchGoodBox = new System.Windows.Forms.TextBox();
            this.supplierTab = new System.Windows.Forms.TabPage();
            this.searchSupplierBox = new System.Windows.Forms.TextBox();
            this.tblSupplier = new System.Windows.Forms.Panel();
            this.tblSupplierSecondName = new System.Windows.Forms.Label();
            this.tblSupplierContent = new System.Windows.Forms.Panel();
            this.tblSupplierID = new System.Windows.Forms.Label();
            this.tblSupplierOptions = new System.Windows.Forms.Label();
            this.tblSupplierName = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.catTab.SuspendLayout();
            this.tblCat.SuspendLayout();
            this.goodsTab.SuspendLayout();
            this.tblGood.SuspendLayout();
            this.supplierTab.SuspendLayout();
            this.tblSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.catTab);
            this.tabControl1.Controls.Add(this.goodsTab);
            this.tabControl1.Controls.Add(this.supplierTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // catTab
            // 
            this.catTab.Controls.Add(this.searchCatBox);
            this.catTab.Controls.Add(this.tblCat);
            this.catTab.Controls.Add(this.btnAddCategory);
            this.catTab.Location = new System.Drawing.Point(4, 22);
            this.catTab.Name = "catTab";
            this.catTab.Padding = new System.Windows.Forms.Padding(3);
            this.catTab.Size = new System.Drawing.Size(611, 312);
            this.catTab.TabIndex = 0;
            this.catTab.Text = "Категорії";
            this.catTab.UseVisualStyleBackColor = true;
            // 
            // searchCatBox
            // 
            this.searchCatBox.Location = new System.Drawing.Point(8, 8);
            this.searchCatBox.Name = "searchCatBox";
            this.searchCatBox.Size = new System.Drawing.Size(186, 20);
            this.searchCatBox.TabIndex = 6;
            this.searchCatBox.Text = "Пошук...";
            this.searchCatBox.Enter += new System.EventHandler(this.searchRemoveText);
            this.searchCatBox.Leave += new System.EventHandler(this.searchAddText);
            // 
            // tblCat
            // 
            this.tblCat.BackColor = System.Drawing.Color.Transparent;
            this.tblCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblCat.Controls.Add(this.tblCatContent);
            this.tblCat.Controls.Add(this.tblCategoryID);
            this.tblCat.Controls.Add(this.tblCategoryOptions);
            this.tblCat.Controls.Add(this.tblCategoryName);
            this.tblCat.Controls.Add(this.tblCategoryGoods);
            this.tblCat.Location = new System.Drawing.Point(-4, 35);
            this.tblCat.Name = "tblCat";
            this.tblCat.Size = new System.Drawing.Size(615, 281);
            this.tblCat.TabIndex = 5;
            // 
            // tblCatContent
            // 
            this.tblCatContent.AutoScroll = true;
            this.tblCatContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblCatContent.Location = new System.Drawing.Point(-1, 16);
            this.tblCatContent.Name = "tblCatContent";
            this.tblCatContent.Size = new System.Drawing.Size(615, 264);
            this.tblCatContent.TabIndex = 5;
            // 
            // tblCategoryID
            // 
            this.tblCategoryID.AutoSize = true;
            this.tblCategoryID.Location = new System.Drawing.Point(8, 0);
            this.tblCategoryID.Name = "tblCategoryID";
            this.tblCategoryID.Size = new System.Drawing.Size(14, 13);
            this.tblCategoryID.TabIndex = 2;
            this.tblCategoryID.Text = "#";
            // 
            // tblCategoryOptions
            // 
            this.tblCategoryOptions.AutoSize = true;
            this.tblCategoryOptions.Location = new System.Drawing.Point(473, 0);
            this.tblCategoryOptions.Name = "tblCategoryOptions";
            this.tblCategoryOptions.Size = new System.Drawing.Size(16, 13);
            this.tblCategoryOptions.TabIndex = 4;
            this.tblCategoryOptions.Text = "...";
            // 
            // tblCategoryName
            // 
            this.tblCategoryName.AutoSize = true;
            this.tblCategoryName.Location = new System.Drawing.Point(34, 0);
            this.tblCategoryName.MaximumSize = new System.Drawing.Size(264, 0);
            this.tblCategoryName.Name = "tblCategoryName";
            this.tblCategoryName.Size = new System.Drawing.Size(39, 13);
            this.tblCategoryName.TabIndex = 2;
            this.tblCategoryName.Text = "Назва";
            // 
            // tblCategoryGoods
            // 
            this.tblCategoryGoods.AutoSize = true;
            this.tblCategoryGoods.Location = new System.Drawing.Point(291, 0);
            this.tblCategoryGoods.Name = "tblCategoryGoods";
            this.tblCategoryGoods.Size = new System.Drawing.Size(93, 13);
            this.tblCategoryGoods.TabIndex = 3;
            this.tblCategoryGoods.Text = "Кількість товарів";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(537, 6);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(68, 23);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Додати";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // goodsTab
            // 
            this.goodsTab.Controls.Add(this.btnAddGood);
            this.goodsTab.Controls.Add(this.tblGood);
            this.goodsTab.Controls.Add(this.searchGoodBox);
            this.goodsTab.Location = new System.Drawing.Point(4, 22);
            this.goodsTab.Name = "goodsTab";
            this.goodsTab.Padding = new System.Windows.Forms.Padding(3);
            this.goodsTab.Size = new System.Drawing.Size(611, 312);
            this.goodsTab.TabIndex = 1;
            this.goodsTab.Text = "Товари";
            this.goodsTab.UseVisualStyleBackColor = true;
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(537, 6);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(68, 23);
            this.btnAddGood.TabIndex = 0;
            this.btnAddGood.Text = "Додати";
            this.btnAddGood.UseVisualStyleBackColor = true;
            // 
            // tblGood
            // 
            this.tblGood.BackColor = System.Drawing.Color.Transparent;
            this.tblGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblGood.Controls.Add(this.tblGoodCategory);
            this.tblGood.Controls.Add(this.tblGoodCount);
            this.tblGood.Controls.Add(this.tblGoodContent);
            this.tblGood.Controls.Add(this.tblGoodID);
            this.tblGood.Controls.Add(this.tblGoodOptions);
            this.tblGood.Controls.Add(this.tblGoodName);
            this.tblGood.Controls.Add(this.tblGoodBrand);
            this.tblGood.Location = new System.Drawing.Point(-4, 35);
            this.tblGood.Name = "tblGood";
            this.tblGood.Size = new System.Drawing.Size(615, 281);
            this.tblGood.TabIndex = 5;
            // 
            // tblGoodCategory
            // 
            this.tblGoodCategory.AutoSize = true;
            this.tblGoodCategory.Location = new System.Drawing.Point(194, 1);
            this.tblGoodCategory.Name = "tblGoodCategory";
            this.tblGoodCategory.Size = new System.Drawing.Size(56, 13);
            this.tblGoodCategory.TabIndex = 7;
            this.tblGoodCategory.Text = "Категорія";
            // 
            // tblGoodCount
            // 
            this.tblGoodCount.AutoSize = true;
            this.tblGoodCount.Location = new System.Drawing.Point(454, 1);
            this.tblGoodCount.Name = "tblGoodCount";
            this.tblGoodCount.Size = new System.Drawing.Size(53, 13);
            this.tblGoodCount.TabIndex = 6;
            this.tblGoodCount.Text = "Кількість";
            this.tblGoodCount.Click += new System.EventHandler(this.tblGoodCount_Click);
            // 
            // tblGoodContent
            // 
            this.tblGoodContent.AutoScroll = true;
            this.tblGoodContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblGoodContent.Location = new System.Drawing.Point(-1, 16);
            this.tblGoodContent.Name = "tblGoodContent";
            this.tblGoodContent.Size = new System.Drawing.Size(615, 264);
            this.tblGoodContent.TabIndex = 5;
            // 
            // tblGoodID
            // 
            this.tblGoodID.AutoSize = true;
            this.tblGoodID.Location = new System.Drawing.Point(8, 0);
            this.tblGoodID.Name = "tblGoodID";
            this.tblGoodID.Size = new System.Drawing.Size(14, 13);
            this.tblGoodID.TabIndex = 2;
            this.tblGoodID.Text = "#";
            // 
            // tblGoodOptions
            // 
            this.tblGoodOptions.AutoSize = true;
            this.tblGoodOptions.Location = new System.Drawing.Point(555, 0);
            this.tblGoodOptions.Name = "tblGoodOptions";
            this.tblGoodOptions.Size = new System.Drawing.Size(16, 13);
            this.tblGoodOptions.TabIndex = 4;
            this.tblGoodOptions.Text = "...";
            // 
            // tblGoodName
            // 
            this.tblGoodName.AutoSize = true;
            this.tblGoodName.Location = new System.Drawing.Point(34, 0);
            this.tblGoodName.MaximumSize = new System.Drawing.Size(264, 0);
            this.tblGoodName.Name = "tblGoodName";
            this.tblGoodName.Size = new System.Drawing.Size(39, 13);
            this.tblGoodName.TabIndex = 2;
            this.tblGoodName.Text = "Назва";
            this.tblGoodName.Click += new System.EventHandler(this.tblGoodName_Click);
            // 
            // tblGoodBrand
            // 
            this.tblGoodBrand.AutoSize = true;
            this.tblGoodBrand.Location = new System.Drawing.Point(333, 0);
            this.tblGoodBrand.Name = "tblGoodBrand";
            this.tblGoodBrand.Size = new System.Drawing.Size(38, 13);
            this.tblGoodBrand.TabIndex = 3;
            this.tblGoodBrand.Text = "Бренд";
            this.tblGoodBrand.Click += new System.EventHandler(this.tblGoodBrand_Click);
            // 
            // searchGoodBox
            // 
            this.searchGoodBox.Location = new System.Drawing.Point(8, 8);
            this.searchGoodBox.Name = "searchGoodBox";
            this.searchGoodBox.Size = new System.Drawing.Size(186, 20);
            this.searchGoodBox.TabIndex = 6;
            this.searchGoodBox.Text = "Пошук...";
            this.searchGoodBox.Enter += new System.EventHandler(this.searchRemoveText);
            this.searchGoodBox.Leave += new System.EventHandler(this.searchAddText);
            // 
            // supplierTab
            // 
            this.supplierTab.Controls.Add(this.searchSupplierBox);
            this.supplierTab.Controls.Add(this.tblSupplier);
            this.supplierTab.Controls.Add(this.btnAddSupplier);
            this.supplierTab.Location = new System.Drawing.Point(4, 22);
            this.supplierTab.Name = "supplierTab";
            this.supplierTab.Padding = new System.Windows.Forms.Padding(3);
            this.supplierTab.Size = new System.Drawing.Size(611, 312);
            this.supplierTab.TabIndex = 0;
            this.supplierTab.Text = "Постачальники";
            this.supplierTab.UseVisualStyleBackColor = true;
            // 
            // searchSupplierBox
            // 
            this.searchSupplierBox.Location = new System.Drawing.Point(8, 8);
            this.searchSupplierBox.Name = "searchSupplierBox";
            this.searchSupplierBox.Size = new System.Drawing.Size(186, 20);
            this.searchSupplierBox.TabIndex = 6;
            this.searchSupplierBox.Text = "Пошук...";
            this.searchSupplierBox.Enter += new System.EventHandler(this.searchRemoveText);
            this.searchSupplierBox.Leave += new System.EventHandler(this.searchAddText);
            // 
            // tblSupplier
            // 
            this.tblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.tblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblSupplier.Controls.Add(this.tblSupplierSecondName);
            this.tblSupplier.Controls.Add(this.tblSupplierContent);
            this.tblSupplier.Controls.Add(this.tblSupplierID);
            this.tblSupplier.Controls.Add(this.tblSupplierOptions);
            this.tblSupplier.Controls.Add(this.tblSupplierName);
            this.tblSupplier.Location = new System.Drawing.Point(-4, 35);
            this.tblSupplier.Name = "tblSupplier";
            this.tblSupplier.Size = new System.Drawing.Size(615, 281);
            this.tblSupplier.TabIndex = 5;
            // 
            // tblSupplierSecondName
            // 
            this.tblSupplierSecondName.AutoSize = true;
            this.tblSupplierSecondName.Location = new System.Drawing.Point(254, 1);
            this.tblSupplierSecondName.MaximumSize = new System.Drawing.Size(264, 0);
            this.tblSupplierSecondName.Name = "tblSupplierSecondName";
            this.tblSupplierSecondName.Size = new System.Drawing.Size(56, 13);
            this.tblSupplierSecondName.TabIndex = 6;
            this.tblSupplierSecondName.Text = "Прізвище";
            this.tblSupplierSecondName.Click += new System.EventHandler(this.tblSupplierSecondName_Click);
            // 
            // tblSupplierContent
            // 
            this.tblSupplierContent.AutoScroll = true;
            this.tblSupplierContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblSupplierContent.Location = new System.Drawing.Point(-1, 16);
            this.tblSupplierContent.Name = "tblSupplierContent";
            this.tblSupplierContent.Size = new System.Drawing.Size(615, 264);
            this.tblSupplierContent.TabIndex = 5;
            // 
            // tblSupplierID
            // 
            this.tblSupplierID.AutoSize = true;
            this.tblSupplierID.Location = new System.Drawing.Point(8, 0);
            this.tblSupplierID.Name = "tblSupplierID";
            this.tblSupplierID.Size = new System.Drawing.Size(14, 13);
            this.tblSupplierID.TabIndex = 2;
            this.tblSupplierID.Text = "#";
            // 
            // tblSupplierOptions
            // 
            this.tblSupplierOptions.AutoSize = true;
            this.tblSupplierOptions.Location = new System.Drawing.Point(541, 0);
            this.tblSupplierOptions.Name = "tblSupplierOptions";
            this.tblSupplierOptions.Size = new System.Drawing.Size(16, 13);
            this.tblSupplierOptions.TabIndex = 4;
            this.tblSupplierOptions.Text = "...";
            // 
            // tblSupplierName
            // 
            this.tblSupplierName.AutoSize = true;
            this.tblSupplierName.Location = new System.Drawing.Point(34, 0);
            this.tblSupplierName.MaximumSize = new System.Drawing.Size(264, 0);
            this.tblSupplierName.Name = "tblSupplierName";
            this.tblSupplierName.Size = new System.Drawing.Size(24, 13);
            this.tblSupplierName.TabIndex = 2;
            this.tblSupplierName.Text = "Імя";
            this.tblSupplierName.Click += new System.EventHandler(this.tblSupplierName_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(537, 6);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(68, 23);
            this.btnAddSupplier.TabIndex = 0;
            this.btnAddSupplier.Text = "Додати";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 338);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 377);
            this.MinimumSize = new System.Drawing.Size(630, 377);
            this.Name = "MainForm";
            this.Text = "Склад: електронний облік товарів";
            this.tabControl1.ResumeLayout(false);
            this.catTab.ResumeLayout(false);
            this.catTab.PerformLayout();
            this.tblCat.ResumeLayout(false);
            this.tblCat.PerformLayout();
            this.goodsTab.ResumeLayout(false);
            this.goodsTab.PerformLayout();
            this.tblGood.ResumeLayout(false);
            this.tblGood.PerformLayout();
            this.supplierTab.ResumeLayout(false);
            this.supplierTab.PerformLayout();
            this.tblSupplier.ResumeLayout(false);
            this.tblSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage catTab;
        private System.Windows.Forms.TabPage goodsTab;
        private System.Windows.Forms.TabPage supplierTab;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label tblCategoryID;
        private System.Windows.Forms.Label tblCategoryName;
        private System.Windows.Forms.Label tblCategoryGoods;
        private System.Windows.Forms.Label tblCategoryOptions;
        private System.Windows.Forms.Panel tblCat;
        private System.Windows.Forms.Panel tblCatContent;
        private System.Windows.Forms.TextBox searchCatBox;
        private System.Windows.Forms.TextBox searchGoodBox;
        private System.Windows.Forms.Panel tblGood;
        private System.Windows.Forms.Panel tblGoodContent;
        private System.Windows.Forms.Label tblGoodID;
        private System.Windows.Forms.Label tblGoodOptions;
        private System.Windows.Forms.Label tblGoodName;
        private System.Windows.Forms.Label tblGoodBrand;
        private System.Windows.Forms.Label tblGoodCategory;
        private System.Windows.Forms.Label tblGoodCount;
        private System.Windows.Forms.TextBox searchSupplierBox;
        private System.Windows.Forms.Panel tblSupplier;
        private System.Windows.Forms.Panel tblSupplierContent;
        private System.Windows.Forms.Label tblSupplierID;
        private System.Windows.Forms.Label tblSupplierOptions;
        private System.Windows.Forms.Label tblSupplierName;
        private System.Windows.Forms.Label tblSupplierSecondName;
    }
}

