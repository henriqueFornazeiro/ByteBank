using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IAutenticavel
    {
        
        public Diretor(double salario, string cpf) : base(salario, cpf) { } //Passando o cpf para a classe Funcionario 

        //override - sobrescreve uma implementação da classe base
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {            
            return Salario * 0.50;
        }
    }
}
