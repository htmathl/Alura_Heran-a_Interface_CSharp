using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Funcionarios
{
    internal class Designer:Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000) { }
        public override double Bonificacao => Salario * 0.17;
        public override void aumentarSalario() => Salario *= 1.11;
    }
}
