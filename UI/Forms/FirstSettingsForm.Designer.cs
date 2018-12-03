namespace UI
{
    partial class FirstSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstSettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtConfigPath = new System.Windows.Forms.TextBox();
            this.btnConfigPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMainPath = new System.Windows.Forms.Button();
            this.txtMainPath = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtConfigPath
            // 
            this.txtConfigPath.Location = new System.Drawing.Point(17, 170);
            this.txtConfigPath.Name = "txtConfigPath";
            this.txtConfigPath.Size = new System.Drawing.Size(382, 20);
            this.txtConfigPath.TabIndex = 1;
            this.txtConfigPath.Click += new System.EventHandler(this.changeConfigPath);
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(405, 169);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.Size = new System.Drawing.Size(23, 22);
            this.btnConfigPath.TabIndex = 2;
            this.btnConfigPath.Text = "...";
            this.btnConfigPath.UseVisualStyleBackColor = true;
            this.btnConfigPath.Click += new System.EventHandler(this.changeConfigPath);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Файл налаштувань:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Директорія:";
            // 
            // btnMainPath
            // 
            this.btnMainPath.Location = new System.Drawing.Point(405, 220);
            this.btnMainPath.Name = "btnMainPath";
            this.btnMainPath.Size = new System.Drawing.Size(23, 22);
            this.btnMainPath.TabIndex = 5;
            this.btnMainPath.Text = "...";
            this.btnMainPath.UseVisualStyleBackColor = true;
            this.btnMainPath.Click += new System.EventHandler(this.changeMainPath);
            // 
            // txtMainPath
            // 
            this.txtMainPath.Location = new System.Drawing.Point(17, 221);
            this.txtMainPath.Name = "txtMainPath";
            this.txtMainPath.Size = new System.Drawing.Size(382, 20);
            this.txtMainPath.TabIndex = 4;
            this.txtMainPath.Click += new System.EventHandler(this.changeMainPath);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Далі";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Json files (*.json)|*.json";
            // 
            // FirstSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMainPath);
            this.Controls.Add(this.txtMainPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfigPath);
            this.Controls.Add(this.txtConfigPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 325);
            this.MinimumSize = new System.Drawing.Size(450, 325);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstSettingsForm";
            this.Text = "Налаштування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtConfigPath;
        private System.Windows.Forms.Button btnConfigPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMainPath;
        private System.Windows.Forms.TextBox txtMainPath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}