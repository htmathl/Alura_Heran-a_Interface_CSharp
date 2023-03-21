using bytebank_ADM_.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Funcionarios
{
    public abstract class FuncionarioAutenticado : Funcionario, IAutenticado
    {
        protected FuncionarioAutenticado(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Login { get; set; }
        public string Senha { get; set; }

        public bool autenticar(string login, string senha)
        {
            return Login == login && Senha == senha;
        }
    }
}
