namespace UI
{
    partial class AddSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierForm));
            this.supp_nameLabel = new System.Windows.Forms.Label();
            this.suppFirstname = new System.Windows.Forms.TextBox();
            this.suppSecondname = new System.Windows.Forms.TextBox();
            this.supp_snameLabel = new System.Windows.Forms.Label();
            this.btnCancelAddSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supp_nameLabel
            // 
            this.supp_nameLabel.AutoSize = true;
            this.supp_nameLabel.Location = new System.Drawing.Point(30, 22);
            this.supp_nameLabel.Name = "supp_nameLabel";
            this.supp_nameLabel.Size = new System.Drawing.Size(24, 13);
            this.supp_nameLabel.TabIndex = 0;
            this.supp_nameLabel.Text = "Імя";
            // 
            // suppFirstname
            // 
            this.suppFirstname.Location = new System.Drawing.Point(33, 38);
            this.suppFirstname.Name = "suppFirstname";
            this.suppFirstname.Size = new System.Drawing.Size(210, 20);
            this.suppFirstname.TabIndex = 1;
            // 
            // suppSecondname
            // 
            this.suppSecondname.Location = new System.Drawing.Point(33, 88);
            this.suppSecondname.Name = "suppSecondname";
            this.suppSecondname.Size = new System.Drawing.Size(210, 20);
            this.suppSecondname.TabIndex = 3;
            // 
            // supp_snameLabel
            // 
            this.supp_snameLabel.AutoSize = true;
            this.supp_snameLabel.Location = new System.Drawing.Point(30, 72);
            this.supp_snameLabel.Name = "supp_snameLabel";
            this.supp_snameLabel.Size = new System.Drawing.Size(56, 13);
            this.supp_snameLabel.TabIndex = 2;
            this.supp_snameLabel.Text = "Прізвище";
            // 
            // btnCancelAddSupplier
            // 
            this.btnCancelAddSupplier.Location = new System.Drawing.Point(168, 127);
            this.btnCancelAddSupplier.Name = "btnCancelAddSupplier";
            this.btnCancelAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddSupplier.TabIndex = 14;
            this.btnCancelAddSupplier.Text = "Відміна";
            this.btnCancelAddSupplier.UseVisualStyleBackColor = true;
            this.btnCancelAddSupplier.Click += new System.EventHandler(this.btnCancelAddSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(33, 127);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplier.TabIndex = 13;
            this.btnAddSupplier.Text = "Додати";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 170);
            this.Controls.Add(this.btnCancelAddSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.suppSecondname);
            this.Controls.Add(this.supp_snameLabel);
            this.Controls.Add(this.suppFirstname);
            this.Controls.Add(this.supp_nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(298, 209);
            this.Name = "AddSupplierForm";
            this.Text = "Додавання постачальника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSupplierForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supp_nameLabel;
        private System.Windows.Forms.TextBox suppFirstname;
        private System.Windows.Forms.TextBox suppSecondname;
        private System.Windows.Forms.Label supp_snameLabel;
        private System.Windows.Forms.Button btnCancelAddSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
    }
}