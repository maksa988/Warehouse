using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Interfaces
{
    public interface IForm
    {
        bool EditMode { get; set; }
        int DataID { get; set; }

        void ChangeMode(bool mode = true);
        void SetResult(string[] result);
        string[] GetResult();
        DialogResult ShowDialog();

        void Hide();
    }
}
