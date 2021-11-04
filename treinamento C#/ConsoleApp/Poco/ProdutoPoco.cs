using System;

namespace ConsoleApp.Poco
{
    public class ProdutoPoco : CamposComuns
    {
        private int produtoId;
        private int subCategoriaID;
        private int categoriaID;

        public ProdutoPoco()
        {
        }

        public int ProdutoId { get => produtoId; set => produtoId = value; }
        public int SubCategoriaID { get => subCategoriaID; set => subCategoriaID = value; }
        public int CategoriaID { get => categoriaID; set => categoriaID = value; }
    }
}
