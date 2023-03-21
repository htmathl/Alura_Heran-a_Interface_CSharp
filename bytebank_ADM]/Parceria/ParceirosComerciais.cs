using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Parceria
{
    public class ParceirosComerciais
    {
        public string Senha { get; set; }
        public bool autenticar(string login, string senha) => Senha == senha;
    }
}
