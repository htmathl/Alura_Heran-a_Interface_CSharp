using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Funcionarios
{
    public class Diretor:Funcionario
    {
        //sobreescrevendo o método da classe funcionário
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }
    }
}
