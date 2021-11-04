using System;

namespace ConsoleApp.Poco
{
    public abstract class CamposComuns : CamposDeData
    {
        protected String descricao;

        public string Descricao { get => descricao; set => descricao = value; }
    }
}
