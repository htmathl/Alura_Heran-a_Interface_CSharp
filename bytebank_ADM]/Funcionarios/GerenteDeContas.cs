﻿using bytebank_ADM_.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Funcionarios
{
    public class GerenteDeContas:Autenticado
    {
        public GerenteDeContas(string cpf) : base(cpf, 3250)
        {
        }
        public override double Bonificacao => Salario * 0.25;
        public override void aumentarSalario()
        {
            Salario *= 1.05;
        }

        public override bool autenticar(string login, string senha)
        {
            return Login == login && Senha == senha;
        }
    }
}
