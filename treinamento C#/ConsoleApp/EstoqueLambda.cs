using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.FakeDB;
namespace ConsoleApp
{
    public class EstoqueLambda
    {

        public EstoqueLambda()
        {
            var c = EstoqueFakeDB.Categorias;
            var s = EstoqueFakeDB.SubCategorias;
            var p = EstoqueFakeDB.Produtos;
        }

        public void ExibirCategoria()
        {
            Console.WriteLine("Testar");
            Console.WriteLine("----");

            EstoqueFakeDB.Categorias
            .Where(c => (c.CategoriaID > 0) && (c.CategoriaID <= 3))
            .ToList()
            .ForEach(cat =>
            {
                Console.WriteLine("Categoria ID: {0}", cat.CategoriaID);
                Console.WriteLine("Descrição: {0}", cat.Descricao);
                Console.WriteLine("-------------");
            });
        }

        public void ExibirSubCategoria(int catid)
        {
            Console.WriteLine("Testar");
            Console.WriteLine("----");

            EstoqueFakeDB.SubCategorias
            .Where(s => (s.CategoriaID == catid))
            .ToList()
            .ForEach(cat =>
            {
                Console.WriteLine("SubCategoria ID: {0}", cat.SubCategoriaID);
                Console.WriteLine("Categoria: {0}", cat.CategoriaID);
                Console.WriteLine("Descrição: {0}", cat.Descricao);
                Console.WriteLine("-------------");
            });
        }

        public void ExibirProduto(int subcatid)
        {
            Console.WriteLine("Testar");
            Console.WriteLine("----");

            EstoqueFakeDB.Produtos
            .Where(s => (s.SubCategoriaID == subcatid))
            .ToList()
            .ForEach(cat =>
            {
                Console.WriteLine("Produto ID: {0}", cat.ProdutoId);
                Console.WriteLine("SubCategoria ID: {0}", cat.SubCategoriaID);
                Console.WriteLine("Categoria: {0}", cat.CategoriaID);
                Console.WriteLine("Descrição: {0}", cat.Descricao);
                Console.WriteLine("-------------");
            });
        }

    }
}
