using bytebank_ADM_.Funcionarios;
using bytebank_ADM_.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.SistemaInterno
{
    public class SistemaInterno
    {
        public bool logar(Autenticado autenticado, string login, string senha)
        {
            bool autenticacao = autenticado.autenticar(login, senha);
            if (autenticacao)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            Console.WriteLine("Login ou senha incorretos!");
            return false;
        }
        public bool logar(ParceirosComerciais parceiro, string login, string senha)
        {
            bool autenticacao = parceiro.autenticar(login, senha);
            if (autenticacao)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            Console.WriteLine("Login ou senha incorretos!");
            return false;
        }
    }
}
