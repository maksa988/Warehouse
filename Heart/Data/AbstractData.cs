using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heart.Interfaces;

namespace Heart.Data
{
    public abstract class AbstractData : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void FromArray(string[] arr)
        {
            this.Name = arr[0];
        }

        public virtual string[] ToArray()
        {
            return new string[] {
                this.Name
            };
        }
        
        public override string ToString()
        {
            return "#" + Id + " - " + Name;
        }
    }
}
