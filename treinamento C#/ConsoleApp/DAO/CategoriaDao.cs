using System;
using ConsoleApp.FakeDB;
using ConsoleApp.Poco;
using System.Collections.Generic;

namespace ConsoleApp.DAO
{
    public class CategoriaDao
    {
        public CategoriaDao()
        {
           var c =  EstoqueFakeDB.Categorias;
        }
        //Adiciona um Funcionario
        public void create(CategoriaPoco poco)
        {
            EstoqueFakeDB.Categorias.Add(poco);
        }
        //lista todos os funcionarios
        public List<CategoriaPoco> readAll()
        {
            return EstoqueFakeDB.Categorias;
        }
        //Busca funcionario pelo id, remove e adiciona um novo elemento
        // public void update(CategoriaPoco poco)
        // {
        //     FuncionarioPojo busca = this.search(pojo.getFuncionarioID());
        //     FuncionarioFakeDB.getFuncionarios().remove(busca);
        //     FuncionarioFakeDB.getFuncionarios().add(pojo);
        // }
        // //busca funcionario pelo id e deleta o funcionario
        // public void delete(int funcioarioID)
        // {
        //     FuncionarioPojo busca = this.search(funcioarioID);
        //     FuncionarioFakeDB.getFuncionarios().remove(busca);
        // }
        // //busca funcionario pelo id
        // public FuncionarioPojo read(int funcionarioID)
        // {
        //     return this.search(funcionarioID);
        // }
        // //metodo search que usa lambda para buscar um funcionario pelo id 
        // public FuncionarioPojo search(int id)
        // {
        //     return FuncionarioFakeDB.getFuncionarios().stream()
        //             .filter(l->l.getFuncionarioID() == id)
        //             .findFirst()
        //             .orElse(null);
        // }
    }
}
