using System;

namespace Database.Config
{
    [Serializable]
    public class ConfigData
    {
        public string Path;
        public string TableExtension = ".table";
        public string TablesDirectory = "tables";
        public string TablesConfig = "__tables.db";

        public ConfigData() { }
    }
}
