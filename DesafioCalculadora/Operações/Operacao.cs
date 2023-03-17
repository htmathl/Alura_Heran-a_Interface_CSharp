using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCalculadora.Operações
{
    public class Operacao
    {
        public double Total { get; private set; }
        private void soma(double num, double num2)
        {
            Total = num + num2;
        }
        private void multiplicacao(double num, double num2)
        {
            Total = num * num2;
        }
        private void subtracao(double num, double num2)
        {
            Total = num - num2;
        }
        private void divisao(double num, double num2)
        {
            Total = num / num2;
        }
        public Operacao(int op, double num, double num2) 
        {
            switch(op)
            {
                case 0:
                    soma(num, num2);
                    break;
                case 1:
                    multiplicacao(num, num2);
                    break;
                case 2:
                    subtracao(num, num2);
                    break;
                case 3:
                    divisao(num, num2);
                    break;
                default:
                    break;
            }
        }
    }
}
