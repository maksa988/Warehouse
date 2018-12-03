namespace UI
{
    partial class AddGoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoodForm));
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.lblGoodName = new System.Windows.Forms.Label();
            this.lblGoodPrice = new System.Windows.Forms.Label();
            this.nmrcGoodPrice = new System.Windows.Forms.NumericUpDown();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblGoodCategory = new System.Windows.Forms.Label();
            this.nmrcGoodCount = new System.Windows.Forms.NumericUpDown();
            this.lblGoodCount = new System.Windows.Forms.Label();
            this.lblGoodBrand = new System.Windows.Forms.Label();
            this.txtGoodBrand = new System.Windows.Forms.TextBox();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.btnCancelAddGood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcGoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcGoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(24, 36);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(236, 20);
            this.txtGoodName.TabIndex = 0;
            // 
            // lblGoodName
            // 
            this.lblGoodName.AutoSize = true;
            this.lblGoodName.Location = new System.Drawing.Point(21, 20);
            this.lblGoodName.Name = "lblGoodName";
            this.lblGoodName.Size = new System.Drawing.Size(76, 13);
            this.lblGoodName.TabIndex = 1;
            this.lblGoodName.Text = "Назва товару";
            // 
            // lblGoodPrice
            // 
            this.lblGoodPrice.AutoSize = true;
            this.lblGoodPrice.Location = new System.Drawing.Point(21, 114);
            this.lblGoodPrice.Name = "lblGoodPrice";
            this.lblGoodPrice.Size = new System.Drawing.Size(128, 13);
            this.lblGoodPrice.TabIndex = 3;
            this.lblGoodPrice.Text = "Ціна за одиницю товару";
            // 
            // nmrcGoodPrice
            // 
            this.nmrcGoodPrice.DecimalPlaces = 2;
            this.nmrcGoodPrice.Location = new System.Drawing.Point(24, 130);
            this.nmrcGoodPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrcGoodPrice.Name = "nmrcGoodPrice";
            this.nmrcGoodPrice.Size = new System.Drawing.Size(236, 20);
            this.nmrcGoodPrice.TabIndex = 4;
            // 
            // cboxCategory
            // 
            this.cboxCategory.DisplayMember = "Оберіть категорію";
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.Items.AddRange(new object[] {
            "#1 - Електроніка",
            "#2 - Для саду"});
            this.cboxCategory.Location = new System.Drawing.Point(24, 178);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(236, 21);
            this.cboxCategory.TabIndex = 5;
            this.cboxCategory.Tag = "";
            // 
            // lblGoodCategory
            // 
            this.lblGoodCategory.AutoSize = true;
            this.lblGoodCategory.Location = new System.Drawing.Point(21, 162);
            this.lblGoodCategory.Name = "lblGoodCategory";
            this.lblGoodCategory.Size = new System.Drawing.Size(56, 13);
            this.lblGoodCategory.TabIndex = 6;
            this.lblGoodCategory.Text = "Категорія";
            // 
            // nmrcGoodCount
            // 
            this.nmrcGoodCount.Location = new System.Drawing.Point(24, 225);
            this.nmrcGoodCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmrcGoodCount.Name = "nmrcGoodCount";
            this.nmrcGoodCount.Size = new System.Drawing.Size(236, 20);
            this.nmrcGoodCount.TabIndex = 7;
            // 
            // lblGoodCount
            // 
            this.lblGoodCount.AutoSize = true;
            this.lblGoodCount.Location = new System.Drawing.Point(21, 209);
            this.lblGoodCount.Name = "lblGoodCount";
            this.lblGoodCount.Size = new System.Drawing.Size(93, 13);
            this.lblGoodCount.TabIndex = 8;
            this.lblGoodCount.Text = "Кількість товарів";
            // 
            // lblGoodBrand
            // 
            this.lblGoodBrand.AutoSize = true;
            this.lblGoodBrand.Location = new System.Drawing.Point(21, 66);
            this.lblGoodBrand.Name = "lblGoodBrand";
            this.lblGoodBrand.Size = new System.Drawing.Size(75, 13);
            this.lblGoodBrand.TabIndex = 9;
            this.lblGoodBrand.Text = "Бренд товару";
            // 
            // txtGoodBrand
            // 
            this.txtGoodBrand.Location = new System.Drawing.Point(24, 82);
            this.txtGoodBrand.Name = "txtGoodBrand";
            this.txtGoodBrand.Size = new System.Drawing.Size(236, 20);
            this.txtGoodBrand.TabIndex = 10;
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(24, 262);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(75, 23);
            this.btnAddGood.TabIndex = 11;
            this.btnAddGood.Text = "Додати";
            this.btnAddGood.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddGood
            // 
            this.btnCancelAddGood.Location = new System.Drawing.Point(185, 262);
            this.btnCancelAddGood.Name = "btnCancelAddGood";
            this.btnCancelAddGood.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddGood.TabIndex = 12;
            this.btnCancelAddGood.Text = "Відміна";
            this.btnCancelAddGood.UseVisualStyleBackColor = true;
            this.btnCancelAddGood.Click += new System.EventHandler(this.btnCancelAddGood_Click);
            // 
            // AddGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 306);
            this.Controls.Add(this.btnCancelAddGood);
            this.Controls.Add(this.btnAddGood);
            this.Controls.Add(this.txtGoodBrand);
            this.Controls.Add(this.lblGoodBrand);
            this.Controls.Add(this.lblGoodCount);
            this.Controls.Add(this.nmrcGoodCount);
            this.Controls.Add(this.lblGoodCategory);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.nmrcGoodPrice);
            this.Controls.Add(this.lblGoodPrice);
            this.Controls.Add(this.lblGoodName);
            this.Controls.Add(this.txtGoodName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(303, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(303, 345);
            this.Name = "AddGoodForm";
            this.Text = "Додавання товару";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddGoodForm_FormClosing);
            this.Resize += new System.EventHandler(this.AddGoodForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcGoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcGoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.Label lblGoodName;
        private System.Windows.Forms.Label lblGoodPrice;
        private System.Windows.Forms.NumericUpDown nmrcGoodPrice;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblGoodCategory;
        private System.Windows.Forms.NumericUpDown nmrcGoodCount;
        private System.Windows.Forms.Label lblGoodCount;
        private System.Windows.Forms.Label lblGoodBrand;
        private System.Windows.Forms.TextBox txtGoodBrand;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.Button btnCancelAddGood;
    }
}