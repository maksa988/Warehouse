using System;
using System.Runtime.Serialization.Json;
using System.IO;

namespace FDHandler.Serialization.Providers
{
    class JsonSerializeProvider : SerializeProvider
    {
        public JsonSerializeProvider(FileStream fs) : base(fs) { }

        public override object Read(Type type)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(type);

            this.SetFSPosition();

            return formatter.ReadObject(this.fs);
        }

        public override void Write(object data)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(data.GetType());

            this.SetFSPosition(0, true);

            formatter.WriteObject(this.fs, data);
        }
    }
}
