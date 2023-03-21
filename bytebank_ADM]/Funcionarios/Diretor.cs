using bytebank_ADM_.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Funcionarios
{
    public class Diretor:FuncionarioAutenticado
    {
        //sobreescrevendo o método da classe funcionário
        public override double Bonificacao => Salario * 0.5;

        public override void aumentarSalario() => Salario += Salario * 0.15;

        public Diretor(string cpf) : base(cpf, 5000) { }
    }
}
