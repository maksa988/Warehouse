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
    public class SupplierController : Controller
    {
        public SupplierController()
        {
            this.form = new AddSupplierForm(this);
        }

        public SupplierController(IForm form) : base(form)
        {
        }

        public SupplierController(IForm form, Heart.Controllers.Controller controller) : base(form, controller)
        {
        }

        public override void AddFromForm(object sender, EventArgs e)
        {
            string[] formResult = this.form.GetResult();

            if (String.IsNullOrWhiteSpace(formResult[0]))
                this.DataController.Error("Введіть імя постачальника");
            else if (String.IsNullOrWhiteSpace(formResult[0]))
                this.DataController.Error("Введіть прізвище постачальника");
            else
            {
                if (this.form.EditMode == true)
                {
                    this.DataController.Edit(this.form.DataID, formResult);
                    this.form.Hide();
                }
                else
                {
                    this.DataController.Add(formResult);
                    this.form.Hide();
                }
            }
        }

        public override void Draw(object data)
        {
            this.MainForm.DrawSuppliersList(data as List<Supplier>);
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
    }
}
