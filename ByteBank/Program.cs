using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Henrique";
            funcionario.CPF = "12345679-89";
            funcionario.Salario = 2000;

            gerenciador.Registrar(funcionario);

            Console.WriteLine(funcionario.Nome);

            Diretor diretor = new Diretor();
            diretor.Nome = "Roberta";
            diretor.Salario = 5000;

            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.GetBonificacao());


            Console.ReadLine();
        }
    }
}
