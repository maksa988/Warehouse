using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Interfaces;
using Heart.Data;
using Heart.Interfaces;
using System.Windows.Forms;

namespace UI.Controllers
{
    public class GoodController : Controller
    {
        private GoodInfoForm GoodInfoForm;

        public GoodController()
        {
            this.form = new AddGoodForm(this);
            this.GoodInfoForm = new GoodInfoForm();
        }

        public GoodController(IForm form) : base(form)
        {
            this.GoodInfoForm = new GoodInfoForm();
        }

        public GoodController(IForm form, Heart.Controllers.Controller controller) : base(form, controller)
        {
            this.GoodInfoForm = new GoodInfoForm();
        }

        public override void ShowAddForm(object sender, EventArgs e)
        {
            this.form.ChangeMode(false);
            this.form.SetResult(new string[] { String.Empty });
            (this.form as AddGoodForm).SetCategories((this.DataController as Heart.Controllers.GoodController).GetCategories());
            this.form.ShowDialog();
        }

        public override void AddFromForm(object sender, EventArgs e)
        {
            string[] goodResult = this.form.GetResult();

            if (String.IsNullOrWhiteSpace(goodResult[0]))
                this.DataController.Error("Введіть назву товару");
            else if (String.IsNullOrWhiteSpace(goodResult[1]))
                this.DataController.Error("Введіть бренд товару");
            else if (String.IsNullOrWhiteSpace(goodResult[3]))
                this.DataController.Error("Оберіть категорію товару");
            else
            {
                if (this.form.EditMode == true)
                {
                    this.DataController.Edit(this.form.DataID, goodResult);
                    this.form.Hide();
                }
                else
                {
                    this.DataController.Add(goodResult);
                    this.form.Hide();
                }
            }
        }

        public override void Draw(object data)
        {
            this.MainForm.DrawGoodsList(data as List<Good>);
        }

        public override void EditBtnClick(object sender, EventArgs e)
        {
            Button current = sender as Button;
            int SupplierID = int.Parse(current.Tag.ToString());

            Supplier supplier = this.DataController.Get(SupplierID) as Supplier;

            if (supplier != null)
            {
                this.form.ChangeMode(true);
                this.form.DataID = supplier.Id;
                this.form.SetResult(supplier.ToArray());
                this.form.ShowDialog();
            }
        }

        public override void RemoveBtnClick(object sender, EventArgs e)
        {
            Button current = sender as Button;
            int id = int.Parse(current.Tag.ToString());

            this.DataController.Remove(id);
        }

        public override void Search(object sender, EventArgs e)
        {
            TextBox sresult = sender as TextBox;
            this.DataController.Search(sresult.Text);
        }

        public override void Sort(string parametr, int type = 0)
        {
            this.DataController.Sort(parametr, type);
        }

        public void DbClickGoodName(object sender, EventArgs e)
        {
            int id = int.Parse((sender as Label).Tag.ToString());
            Good good = this.DataController.Get(id) as Good;

            string[] goodInfo = new string[6];

            goodInfo[0] = good.ToArray()[0];
            goodInfo[1] = good.ToArray()[1];
            goodInfo[2] = good.ToArray()[2];
            goodInfo[3] = good.ToArray()[3];
            goodInfo[4] = good.ToArray()[4];

            goodInfo[3] = (this.DataController as Heart.Controllers.GoodController).GetCatName(good);
            goodInfo[5] = (float.Parse(goodInfo[2]) * int.Parse(goodInfo[4])).ToString();

            this.GoodInfoForm.SetResult(goodInfo);
            this.GoodInfoForm.ShowDialog();
        }
    }
}
