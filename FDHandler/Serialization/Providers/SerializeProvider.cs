using System;
using System.IO;

namespace FDHandler.Serialization.Providers
{
    abstract public class SerializeProvider
    {
        protected FileStream fs;

        abstract public void Write(object data);
        abstract public Object Read(Type type);

        public SerializeProvider(FileStream fs)
        {
            this.fs = fs;
        }

        public void SetFSPosition(int position = 0, bool clean = false)
        {
            this.fs.Position = position;

            if (clean)
                this.fs.SetLength(0);
        }
    }
}
