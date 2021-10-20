using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarDelegate()   
        {
            Calculadora.Executar();
        }
    }

    delegate double MetodoMultiplicacao(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            //Executa diretamente o método
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //Executa diretamente o método
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));


            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"Triplicar(7.5): {metodoMultiplicacao(7.5)}");

            //instancia um delegado com um metodo anônimo
            MetodoMultiplicacao metroQuadrado = delegate (double input)
            {
                return input * input;
            };


            double quadrado = metroQuadrado(5);
            Console.WriteLine("quadrado: {0}", quadrado);

            //instacia um delegado com uma expressão lambda
            MetodoMultiplicacao metodoCubo = input => input * input * input;

            double cubo = metodoCubo(4.375);

            Console.WriteLine("Cubo: {0}", cubo);
        }
    }
}