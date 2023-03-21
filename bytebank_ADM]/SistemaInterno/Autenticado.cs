using bytebank_ADM_.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.SistemaInterno
{
    public abstract class Autenticado : Funcionario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public abstract bool autenticar(string login, string senha);
        public Autenticado(string cpf, double salario) : base(cpf, salario)
        {
        }
    }
}
