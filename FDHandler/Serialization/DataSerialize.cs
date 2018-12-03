using System.IO;
using FDHandler.Serialization.Providers;

namespace FDHandler.Serialization
{
    class DataSerialize
    {
        public XMLSerializeProvider XMLProvider;
        public BinarySerializeProvider BinaryProvider;
        public SoapSerializePrivoder SoapProvider;
        public JsonSerializeProvider JsonProvider;

        public DataSerialize(FileStream fs)
        {
            XMLProvider = new XMLSerializeProvider(fs);
            BinaryProvider = new BinarySerializeProvider(fs);
            SoapProvider = new SoapSerializePrivoder(fs);
            JsonProvider = new JsonSerializeProvider(fs);
        }
    }
}
