using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FirstSettingsForm : Form
    {
        private Common _common;

        private string _defaultConfigPath = Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar + "config.json";
        private string _defaultMainPath = Environment.CurrentDirectory;

        public FirstSettingsForm(Common common)
        {
            this._common = common;

            InitializeComponent();

            this.btnSave.Click += this._common.SaveSettingsClick;

            this.txtConfigPath.Text = this._defaultConfigPath;
            this.txtMainPath.Text = this._defaultMainPath;
            this.txtMainPath.Focus();
        }

        public string[] GetResult()
        {
            return new string[] {
                this.txtConfigPath.Text,
                this.txtMainPath.Text
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeConfigPath(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = this.txtConfigPath.Text;
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "config.json";
            this.openFileDialog1.ShowDialog();
            this.txtConfigPath.Text = this.openFileDialog1.FileName;
        }

        private void changeMainPath(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.SelectedPath = this.txtMainPath.Text;
            this.folderBrowserDialog1.ShowDialog();
            this.txtMainPath.Text = this.folderBrowserDialog1.SelectedPath;
        }
    }
}
