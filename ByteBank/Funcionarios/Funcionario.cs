using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //abstract - não deve ser diretamente instanciado
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //protected - será publico apenas para a própria classe quanto para classes derivadas.
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário...");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //virtual - classes derivadas que herdam a classe base podem mudar a implementação
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
       

    }
}
