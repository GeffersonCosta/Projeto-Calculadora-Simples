using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora.Entities
{
    class Calculo
    {
        public int A { get; set; }
        public int B { get; set; }

        public Calculo(int a, int b)
        {
            A = a;
            B = b;
        }
        public double Operacao(double operador)
        {
            double soma = 0.0;
         
            switch (operador)
            {
                case 1:
                    soma = A + B;
                  
                    break;
                case 2:
                    soma = A - B;
                 
                    break;
                case 3:
                    soma = A * B;
                 
                    break;
                case 4:
                    soma = A / B;
                 
                    break;
            }
            return soma;

        }
       
    }
}
