using System;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace FDHandler.Serialization.Providers
{
    class SoapSerializePrivoder : SerializeProvider
    {
        private SoapFormatter _formatter;

        public SoapSerializePrivoder(FileStream fs) : base(fs)
        {
            this._formatter = new SoapFormatter();
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
