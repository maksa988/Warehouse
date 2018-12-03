using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart.Interfaces
{
    public interface IData
    {
        int Id { get; set; }
        string Name { get; set; }

        void FromArray(string[] arr);
        string ToString();
        string[] ToArray();
    }
}
