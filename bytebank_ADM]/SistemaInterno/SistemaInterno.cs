using bytebank_ADM_.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.SistemaInterno
{
    public class SistemaInterno
    {
        public bool logar(Diretor diretor, string senha)
        {
            bool autenticacao = diretor.autenticar(senha);
            if (autenticacao)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            Console.WriteLine("Senha incorreta!");
            return false;
        }
        public bool logar(GerenteDeContas gerenteDeContas, string senha)
        {
            bool autenticacao = gerenteDeContas.autenticar(senha);
            if (autenticacao)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
}
