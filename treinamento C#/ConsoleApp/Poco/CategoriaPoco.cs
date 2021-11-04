using System;

namespace ConsoleApp.Poco
{
    public class CategoriaPoco : CamposComuns
    {
        private int categoriaID;

        public CategoriaPoco()
        {
        }

        public int CategoriaID { get => categoriaID; set => categoriaID = value; }
    }
}
