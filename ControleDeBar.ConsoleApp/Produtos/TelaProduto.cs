using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.Produtos
{
    public class TelaProduto : TelaBase<Produto>, ITela
    {
        public TelaProduto(RepositorioProduto repositorio) : base("Produto", repositorio)
        {

        }
        public override void VisualizarRegistros(bool exibirCabecalho)
        {
          
            if (exibirCabecalho)
                ExibirCabecalho();

            Console.WriteLine("Visualizar produtos");

            Console.WriteLine();

            Console.WriteLine(
                "{0,-10} | {1,-30} | {2,-30}",
                "Id", "nome", "valor "
            );

            Produto[] produto = repositorio.SelecionarRegistros();

            for (int i = 0; i < produto.Length; i++)
            {
                Produto p = produto[i];
                if (p == null)
                    continue;

                Console.WriteLine(
                    "{0,-10} | {1,-30} | {2,-30}",
                    p.Id, p.Nome, p.Valor.ToString ("c2")
                );
            }
            ApresentarMensagem("Pressione ENTER para continuar...", ConsoleColor.Yellow);
        }
        protected override Produto ObterDados()
        {
            string nome = "";

            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("Digite o nome do produto: ");
                nome = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(nome))
                {
                    ApresentarMensagem("O nome não pode ser vazio!", ConsoleColor.Red);
                }
            }

            bool conseguiuConverterValor = false;

            decimal valor = 0.0m;

            while (!conseguiuConverterValor)
            {
                Console.Write("Digite o nome do valor do produto: ");
                conseguiuConverterValor = decimal.TryParse(Console.ReadLine(), out valor);

                if (!conseguiuConverterValor)
                {
                    ApresentarMensagem("Digite um valor valido!", ConsoleColor.Red);
                }
            }
            return new Produto(nome, valor);
        }
    }
}
