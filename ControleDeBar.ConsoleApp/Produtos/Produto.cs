using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.Produtos
{
    public class Produto : EntidadeBase<Produto>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public override void AtualizarRegistro(Produto registroAtualizado)
        {
            Nome = registroAtualizado.Nome;
            Valor = registroAtualizado.Valor;
        }

        public override string Validar()
        {
            string erros = string.Empty;

            if (Nome.Length < 2 || Nome.Length > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                erros += "O campo \"Nome\" deve conter entre 2 a 100 caracteres.\n";
                Console.ResetColor();
            }

            if (Valor == 0.0m)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                erros += "O campo \"Preço\" deve ser maior que zero.\n";
                Console.ResetColor();
            }

            return erros;
        }
    }
}
