using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Table.Interfaces;

namespace Database.Table
{
    class TableCompare<T> : IComparer<T> where T : ITableData<T>
    {
        private string _parametr;

        public TableCompare(string parametr)
        {
            this._parametr = parametr;
        }

        public int Compare(T x, T y)
        {
            return x.SortCompare(y, this._parametr);
        }
    }
}
