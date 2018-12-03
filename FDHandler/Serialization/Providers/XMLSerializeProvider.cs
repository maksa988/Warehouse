using System;
using System.Xml.Serialization;
using System.IO;

namespace FDHandler.Serialization.Providers
{
    class XMLSerializeProvider : SerializeProvider
    {
        public XMLSerializeProvider(FileStream fs) : base(fs) { }
        
        public override object Read(Type type)
        {
            XmlSerializer formatterr = new XmlSerializer(type);

            this.SetFSPosition();

            return formatterr.Deserialize(this.fs);
        }

        public override void Write(object data)
        {
            XmlSerializer formatter = new XmlSerializer(data.GetType());

            this.SetFSPosition(0, true);

            formatter.Serialize(this.fs, data);
        }
    }
}
