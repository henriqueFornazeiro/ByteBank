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
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer designer = new Designer(3000, "123.456.789-12");
            designer.Nome = "Pedro";

            Auxiliar auxiliar = new Auxiliar(2000, "789.654.321-13");
            auxiliar.Nome = "Igor";

            GerenteDeConta gerenteDeConta = new GerenteDeConta(4000, "987.456.321-14");
            gerenteDeConta.Nome = "Camila";

            Diretor diretor = new Diretor(5000, "321.456.987-15");
            diretor.Nome = "Roberta";

            gerenciadorBonificacao.Registrar(designer);
            gerenciadorBonificacao.Registrar(auxiliar);
            gerenciadorBonificacao.Registrar(gerenteDeConta);
            gerenciadorBonificacao.Registrar(diretor);

            Console.WriteLine("Total bonificações: " + gerenciadorBonificacao.GetTotalBonificacao());

        }

    }
}
