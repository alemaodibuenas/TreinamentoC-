using System;
using ConsoleApp.DAO;
namespace ConsoleApp.Service
{
    public class Menu
    {
        public void exibirMenu()
        {

            int op = 1;

            EstoqueLambda estoque = new EstoqueLambda();

            while (op != 0)
            {
                this.menu();
                Console.WriteLine("Digite uma opção: \n");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        while (op != 0)
                        {
                            menuCategoria();
                            Console.WriteLine("Digite uma opção: \n");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    //lambda.adicionarFuncionario();
                                    break;
                                case 2:
                                    estoque.ExibirCategoria();
                                    op = 0;
                                    break;
                                case 3:
                                   // funcionario.detalharFuncionario();
                                    break;
                                case 4:
                                    //funcionario.alterFuncionario();
                                    break;
                                case 5:
                                    //funcionario.excluirFuncionario();
                                    break;
                            }
                        }
                        op = Convert.ToInt32(Console.ReadLine());
                        //estoque.ExibirCategoria();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }

            if (op == 0)
            {
                Console.WriteLine("Programa encerrado!");
            }
        }

        public void menu()
        {
            Console.WriteLine("+-----------------------------------------+\n");
            Console.WriteLine("|             Menu Opções                 |\n");
            Console.WriteLine("|-----------------------------------------|\n");
            Console.WriteLine("| 1 - Listar     Categoria                |\n");
            Console.WriteLine("| 2 - Listar     SubCategoria             |\n");
            Console.WriteLine("| 3 - Listar     Produto                  |\n");
            Console.WriteLine("| 0 - Sair do  Programa                   |\n");
            Console.WriteLine("+-----------------------------------------+\n");
        }

        public void menuCategoria()
        {
            Console.WriteLine("+-----------------------------------------+\n");
            Console.WriteLine("|             Menu Opções                 |\n");
            Console.WriteLine("|-----------------------------------------|\n");
            Console.WriteLine("| 1 - Cadastrar  Categoria                |\n");
            Console.WriteLine("| 2 - Listar     Categoria                |\n");
            Console.WriteLine("| 3 - Detalhar   Categoria                |\n");
            Console.WriteLine("| 4 - Alterar    Categoria                |\n");
            Console.WriteLine("| 5 - Excluir    Categoria                |\n");
            Console.WriteLine("| 0 - Sair do  Programa                   |\n");
            Console.WriteLine("+-----------------------------------------+\n");
        }

        public void menuSubCategoria()
        {
            Console.WriteLine("+-----------------------------------------+\n");
            Console.WriteLine("|             Menu Opções                 |\n");
            Console.WriteLine("|-----------------------------------------|\n");
            Console.WriteLine("| 1 - Cadastrar  SubCategoria             |\n");
            Console.WriteLine("| 2 - Listar     SubCategoria             |\n");
            Console.WriteLine("| 3 - Detalhar   SubCategoria             |\n");
            Console.WriteLine("| 4 - Alterar    SubCategoria             |\n");
            Console.WriteLine("| 5 - Excluir    SubCategoria             |\n");
            Console.WriteLine("| 0 - Sair do  Programa                   |\n");
            Console.WriteLine("+-----------------------------------------+\n");
        }

        public void menuProduto()
        {
            Console.WriteLine("+-----------------------------------------+\n");
            Console.WriteLine("|             Menu Opções                 |\n");
            Console.WriteLine("|-----------------------------------------|\n");
            Console.WriteLine("| 1 - Cadastrar  Produto                  |\n");
            Console.WriteLine("| 2 - Listar     Produto                  |\n");
            Console.WriteLine("| 3 - Detalhar   Produto                  |\n");
            Console.WriteLine("| 4 - Alterar    Produto                  |\n");
            Console.WriteLine("| 5 - Excluir    Produto                  |\n");
            Console.WriteLine("| 0 - Sair do  Programa                   |\n");
            Console.WriteLine("+-----------------------------------------+\n");
        }
        
    }
    
}
//EstoqueLambda estoque = new EstoqueLambda();
//estoque.TestarExibicao();
//Console.ReadLine(); 