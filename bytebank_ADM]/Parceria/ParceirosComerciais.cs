using bytebank_ADM_.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Parceria
{
    public class ParceirosComerciais:IAutenticado
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool autenticar(string login, string senha) => Senha == senha;
    }
}
