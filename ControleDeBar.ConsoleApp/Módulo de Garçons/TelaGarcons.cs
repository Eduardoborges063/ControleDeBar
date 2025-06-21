using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.Módulo_de_Garçons
{
    public class TelaGarcons : TelaBase<Garcons>, ITela
    {
        public TelaGarcons(RepositorioGarcons repositorio) : base("Garcons", repositorio)
        {
        }
        public override void VisualizarRegistros(bool exibirCabecalho)
        {
            //para que isso
            if (exibirCabecalho)
                ExibirCabecalho();

            Console.WriteLine("Visualizar Garcons");

            Console.WriteLine();

            Console.WriteLine(
                "{0,-10} | {1,-30} | {2,-30}",
                "Id","nome","CPF"
            );

            Garcons[] garcons = repositorio.SelecionarRegistros();

            for (int i = 0; i < garcons.Length; i++)
            {
                Garcons g = garcons[i];
                if (g == null)
                    continue;

                string statusGarcom = g.EstaOcupada ? "Sim" : "Não";

                Console.WriteLine(
                    "{0,-10} | {1,-30} | {2,-30}",
                    g.EstaOcupada, g.nome, g.CPF
                );
            }
        }
        protected override Garcons ObterDados()
        {
            string nome = "";
            string CPF = string.Empty;

            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("Digite o nome do garçom: ");
                nome = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(nome))
                {
                    ApresentarMensagem("O nome não pode ser vazio!", ConsoleColor.Red);
                }
            }

            while (string.IsNullOrWhiteSpace(CPF))
            {
                Console.Write("Digite o nome do CPF: ");
                CPF = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(CPF))
                {
                 
                    ApresentarMensagem("O CPf não pode ser vazio!", ConsoleColor.Red);
                }
            }
            return new Garcons(nome, CPF);
        }
    }
}
