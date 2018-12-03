using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Table.Interfaces
{
    public interface ITableData<T>
    {
        int Id { get; set; }

        bool SearchData(object data, string parametr = null);
        int SortCompare(T other, string parametr = "id");
        string[] ToArray();
    }
}
