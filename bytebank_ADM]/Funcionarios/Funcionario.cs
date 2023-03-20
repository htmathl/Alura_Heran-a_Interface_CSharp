using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM_.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set;}
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public abstract double Bonificacao { get; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
            Console.WriteLine("Criando um funcionário");
        }
        public abstract void aumentarSalario();
    }
}
