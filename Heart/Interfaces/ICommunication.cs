using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heart.Data;

namespace Heart.Interfaces
{
    public interface ICommunication
    {
        void DataChanged(Type type, object data);
        void ErrorTrigger(string message);
        void FirstSettings();
        void StartProgram();
        void ClosePorgram();
    }
}
