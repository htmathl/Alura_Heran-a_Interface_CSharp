using bytebank_ADM_.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void registrar(Funcionario funcionario)
        {
            TotalDeBonificacao += funcionario.Bonificacao;
        }
        ////sobrecarga de métodos
        //public void registrar(Diretor diretor)
        //{
        //    TotalDeBonificacao += diretor.GetBonificacao();
        //}
        //não é preciso pois agora a classe diretor herda funcionário
    }
}
