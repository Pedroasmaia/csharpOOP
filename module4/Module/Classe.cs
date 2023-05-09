using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Triangulo
    {
        public double A,B,C;

        //Public permite que seja chamado em outros arquivos
        //Double é o tipo
        //Area é o nome, que deve sempre estar em letra maiuscula e entre os () passamos os parametros
        public double Area(){
            double p = (A + B + C)/2.0;
            return Math.Sqrt(p * (p - A) * (p - C) * (p - C));
        
        }

    }

}
