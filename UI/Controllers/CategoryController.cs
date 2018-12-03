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
    public class CategoryController : Controller
    {
        public CategoryController()
        {
            this.form = new AddCategoryForm(this);
        }

        public CategoryController(IForm form) : base(form)
        {
        }

        public CategoryController(IForm form, Heart.Controllers.Controller controller) : base(form, controller)
        {
        }

        public override void AddFromForm(object sender, EventArgs e)
        {
            string[] formResult = this.form.GetResult();

            if (String.IsNullOrWhiteSpace(formResult[0]))
                this.DataController.Error("Введіть назву категорії");
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
            this.MainForm.DrawCategoriesList(data as List<Category>);
        }

        public override void EditBtnClick(object sender, EventArgs e)
        {
            Button current = sender as Button;
            int catID = int.Parse(current.Tag.ToString());

            Category cat = this.DataController.Get(catID) as Category;

            if (cat != null)
            {
                this.form.ChangeMode(true);
                this.form.DataID = cat.Id;
                this.form.SetResult(cat.ToArray());
                this.form.ShowDialog();
            }
        }

        public override void RemoveBtnClick(object sender, EventArgs e)
        {
            Button current = sender as Button;
            int id = int.Parse(current.Tag.ToString());

            if (this.GetCountGoods(id) >= 1)
                this.DataController.Error("В цій категорії є товари, спочатку видаліть їх");
            else
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

        public string GetName(int id)
        {
            return (this.DataController.Get(id) as Category).Name;
        }

        public int GetCountGoods(int id)
        {
            return this.DataController.Brain.GoodDataController.GetCountGoods(id);
        }
    }
}
