using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_01_06.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        // exercicio 3
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.tipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // exercicio 6
        public override void Sacar(decimal valor)
        {
            valor += 0.10M;
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
}
