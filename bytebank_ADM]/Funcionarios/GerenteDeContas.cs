using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Funcionarios
{
    internal class GerenteDeContas:Funcionario
    {
        public GerenteDeContas(string cpf) : base(cpf, 3250)
        {
        }
        public override double Bonificacao => Salario * 0.25;
        public override void aumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
