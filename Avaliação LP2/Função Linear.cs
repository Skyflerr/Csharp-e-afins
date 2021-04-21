using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliação_Questão_9
{
    class FuncaoLinear
    {
        private double CoeficienteAngular;
        public double CoeficienteLinear;

        public FuncaoLinear(double x ,double y)
        {
            SetCoeficienteAngular(x);
            CoeficienteLinear = y;
        }

        public bool SetCoeficienteAngular(double x)
        { // restringe o coeficiente angular de ser igual a 0 
            if (x != 0)
            {
                CoeficienteAngular = x;
                return true;
            }

            return false;
        }

        public double GetCoeficienteAngular()
        {
            return CoeficienteAngular;
        }

        public double root() //piadinhas com raiz e talz
        {
            double resultado = (CoeficienteLinear = CoeficienteLinear * (-1)) / CoeficienteAngular;
            return resultado;
        }

        public string inclinação()
        {
            string resposta = "";

            if (CoeficienteAngular > 0)
            {
                resposta = "Crescente";
            }

            else
            {
                resposta = "Decrecente";
            }
            return resposta;
        }
        public string descricao()
        {
            string descricao = "f(x) = "+ CoeficienteAngular + "x " + "+ " + CoeficienteLinear;
            return descricao;
        }
    }
}
