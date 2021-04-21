using System;
using System.Runtime.InteropServices;

namespace Avaliação_Questão_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Função linear ,digite o valor A : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Agora digite o B : ");
            b = Convert.ToDouble(Console.ReadLine());

            FuncaoLinear funcao = new FuncaoLinear(a,b);

            if (funcao.SetCoeficienteAngular(a) == false)
            {
                Console.WriteLine("Parece que seu 'a' é igual a zero :( ");
                Console.ReadLine();
            }

            else
            {
                Console.Write("Aqui esta : " + funcao.descricao() +"\n");
                Console.Write("A inclinação é : "+ funcao.inclinação() + "\n");
                Console.Write("E a raiz é : "+ funcao.root() + "\n");
                Console.ReadLine();
            }
        }
    }
}
