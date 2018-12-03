using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Interfaces;
using Heart.Controllers;

namespace UI.Controllers
{
    public abstract class Controller
    {
        protected IForm form;

        public Heart.Controllers.Controller DataController;
        public MainForm MainForm;

        public Controller()
        {

        }

        public Controller(IForm form)
        {
            this.form = form;
        }

        public Controller(IForm form, Heart.Controllers.Controller controller)
        {
            this.form = form;
            this.DataController = controller;
        }

        public virtual void ShowAddForm(object sender, EventArgs e)
        {
            this.form.ChangeMode(false);
            this.form.SetResult(new string[] { String.Empty });
            this.form.ShowDialog();
        }

        public abstract void AddFromForm(object sender, EventArgs e);
        public abstract void RemoveBtnClick(object sender, EventArgs e);
        public abstract void EditBtnClick(object sender, EventArgs e);
        public abstract void Search(object sender, EventArgs e);

        public abstract void Sort(string parametr, int type = 0);
        public abstract void Draw(object data);
    }
}
