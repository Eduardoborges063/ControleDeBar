using ControleDeBar.ConsoleApp.Módulo_de_Garçons;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.Produtos;

namespace ControleDeBar.ConsoleApp.Compartilhado;

public class TelaPrincipal
{
    private char opcaoEscolhida;

    private RepositorioGarcons repositorioGarcons;
    private RepositorioMesa repositorioMesa;
    private RepositorioProduto repositorioProduto;

    private TelaMesa telaMesa;
    private TelaGarcons telaGarcons;
    private TelaProduto telaProdutos;
    public TelaPrincipal()
    {
        repositorioGarcons = new RepositorioGarcons();
        repositorioMesa = new RepositorioMesa();
        repositorioProduto = new RepositorioProduto();

        telaProdutos = new TelaProduto(repositorioProduto);
        telaMesa = new TelaMesa(repositorioMesa);
        telaGarcons = new TelaGarcons(repositorioGarcons);
    }

    public void ApresentarMenuPrincipal()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|           Controle de Bar            |");
        Console.WriteLine("----------------------------------------");
        Console.ResetColor();

        Console.WriteLine();

        Console.WriteLine("1 - Controle de Mesas");
        Console.WriteLine("2 - Controle de Garçons");
        Console.WriteLine("3 - Controle de Produtos");
        Console.WriteLine("4 - Controle de Contas");
        Console.WriteLine("S - Sair");

        Console.WriteLine();

        Console.Write("Escolha uma das opções: ", ConsoleColor.White);
        opcaoEscolhida = Console.ReadLine()![0];
    }

    public ITela ObterTela()
    {
        if (opcaoEscolhida == '1')
            return telaMesa;

        if (opcaoEscolhida == '2')
          return telaGarcons;

        if (opcaoEscolhida == '3')
            return telaProdutos;

        if (opcaoEscolhida == '4')
            return null;

        return null;
    }
}
