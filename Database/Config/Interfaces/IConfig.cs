using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Config.Interfaces
{
    interface IConfig
    {
        string Path { get; }
        string TableExt { get; }
        string TablesDirectory { get; }
        string TablesConfig { get; }

        void LoadFromFile(string path);
        string TablesDir(string path);
        string TablePath(string path);
    }
}
