using ControleDeBar.ConsoleApp.Compartilhado;
using System.Text.RegularExpressions;

namespace ControleDeBar.ConsoleApp.ModuloMesa;
  public class Garcons : EntidadeBase<Garcons>
  {
    public string nome { get; set; }
    public string CPF { get; set; }
    public bool EstaOcupada { get; set; }
    public bool Disponivel { get; internal set; }

    public Garcons(string nome, string CPF,bool Estaocupado=false)
    {
        this.EstaOcupada = Estaocupado;
        this.nome = nome;
        this.CPF = CPF;
        bool GarconsDisponivel = true;
    }

    public void Ocupar()
    {
            EstaOcupada = true;
    }

    public void Desocupar()
    {
           EstaOcupada = false;
    }

    public override void AtualizarRegistro(Garcons registroAtualizado)
    {
          nome = registroAtualizado.nome;
            CPF = registroAtualizado.CPF;
    }
    public override string Validar()
    {
       string erros = string.Empty;

      if (nome.Length < 3 || nome.Length > 100)
            Console.ForegroundColor = ConsoleColor.Red;
        erros += ("O campo \"Nome\" deve conter entre 3 a 100 caracteres.");
        Console.ResetColor();


        if (Regex.IsMatch(CPF, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            Console.ForegroundColor = ConsoleColor.Red;
        erros += "O campo \"CPF\" deve conter exatamente 11 caracteres.(XXX.XXX.XXX-XX)";
        Console.ResetColor();

        return erros;
    }
  }

/*
 * coolocar cor na mensagem.
 * Console.ForegroundColor = ConsoleColor.Red;
Console.ResetColor();*/
