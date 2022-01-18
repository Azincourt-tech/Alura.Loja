using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Funções para usar no sql"
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();
            //AtualizaProdutos();
            #endregion






        }












        #region "Metodos do sql"
        //private static void AtualizaProdutos()
        //{
        //    GravarUsandoEntity();
        //    RecuperarProdutos();

        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        Produto primeiro = repo.Produtos().First();
        //        primeiro.Nome = "Cassino Royale";
        //        repo.Atualizar(primeiro);
        //    }

        //    RecuperarProdutos();
        //}


        //private static void ExcluirProdutos()
        //{
        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        IList<Produto> produtos = repo.Produtos();
        //        foreach (var item in produtos)
        //        {
        //            repo.Remover(item);

        //        }
        //    }
        //}

        //private static void RecuperarProdutos()
        //{
        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        IList<Produto> produtos = repo.Produtos();
        //        Console.WriteLine("Foram encontrados {0} produtos", produtos.Count);
        //        foreach (var item in produtos)
        //        {
        //            Console.WriteLine(item.Nome);
        //        }
        //    }
        //}

        //private static void GravarUsandoEntity()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.Preco = 19.89;

        //    using (var contexto = new ProdutoDAOEntity())
        //    {
        //      contexto.Adicionar(p);
        //    }
        //}

        #endregion

    }
}
