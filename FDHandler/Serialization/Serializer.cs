using System;
using System.IO;

namespace FDHandler.Serialization
{
    public class Serializer
    {
        private DataSerialize _dataSerialize;

        public Serializer(FileStream fs)
        {
            this._dataSerialize = new DataSerialize(fs);
        }

        public object ReadXML(Type type)
        {
            return this._dataSerialize.XMLProvider.Read(type);
        }

        public void WriteXML(object data)
        {
            this._dataSerialize.XMLProvider.Write(data);
        }

        public object ReadBin(Type type)
        {
            return this._dataSerialize.BinaryProvider.Read(type);
        }

        public void WriteBin(object data)
        {
            this._dataSerialize.BinaryProvider.Write(data);
        }

        public object ReadSoap(Type type)
        {
            return this._dataSerialize.SoapProvider.Read(type);
        }

        public void WriteSoap(object data)
        {
            this._dataSerialize.SoapProvider.Write(data);
        }

        public object ReadJson(Type type)
        {
            return this._dataSerialize.JsonProvider.Read(type);
        }

        public void WriteJson(object data)
        {
            this._dataSerialize.JsonProvider.Write(data);
        }
    }
}
