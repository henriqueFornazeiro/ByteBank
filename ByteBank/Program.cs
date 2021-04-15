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

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.Salario);
            Console.WriteLine(funcionario.GetBonificacao());
            gerenciador.Registrar(funcionario);

            Diretor diretor = new Diretor();
            diretor.Nome = "Roberta";
            diretor.Salario = 5000;
            
            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.Salario);
            Console.WriteLine(diretor.GetBonificacao());
            gerenciador.Registrar(diretor);
            Console.WriteLine("Total de bonificações: "+gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
