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
    public partial class GoodInfoForm : Form
    {
        public GoodInfoForm()
        {
            InitializeComponent();
        }

        public void SetResult(string[] result)
        {
            this.lblGoodName.Text = result[0];
            this.lblGoodBrand.Text = result[1];
            this.lblGoodPrice.Text = result[2] + " грн.";
            this.lblGoodCat.Text = result[3];
            this.lblGoodCount.Text = result[4];
            this.lblGoodTotalPrice.Text = result[5] + " грн.";
        }

        private void GoodInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
