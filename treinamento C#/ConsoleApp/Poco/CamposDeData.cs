using System;

namespace ConsoleApp.Poco
{
    public abstract class CamposDeData
    {
        protected DateTime dataInsert;

        public DateTime DataInsert { get => dataInsert; set => dataInsert = value; }
    }
}
