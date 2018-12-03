using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDHandler;

namespace Database.Table.Interfaces
{
    public interface ITable
    {
        string Name { get; }

        void SetHandler(FileHandler handler);
        void Delete();
        void Truncate();
        void LoadData();
        void SaveData();
    }
}
