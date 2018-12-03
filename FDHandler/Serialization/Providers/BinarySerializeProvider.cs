using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FDHandler.Serialization.Providers
{
    class BinarySerializeProvider : SerializeProvider
    {
        private BinaryFormatter _formatter;

        public BinarySerializeProvider(FileStream fs) : base(fs)
        {
            this._formatter = new BinaryFormatter();
        }

        public override object Read(Type type)
        {
            this.SetFSPosition();

            return this._formatter.Deserialize(this.fs);
        }

        public override void Write(object data)
        {
            this.SetFSPosition(0, true);

            this._formatter.Serialize(this.fs, data);
        }
    }
}
