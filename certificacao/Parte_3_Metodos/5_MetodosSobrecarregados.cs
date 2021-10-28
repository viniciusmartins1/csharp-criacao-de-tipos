using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarMetodosSobrecarregados()
        {


           //VOLUME DO CUBO = lado ^ 3;
           int lado = 3;
           Console.WriteLine("Volume do Cubo: " + Volume(lado));



            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;
            Console.WriteLine("Volume do Cilindro: " + Volume(altura, raio));




            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine("Volume do Prisma: " + Volume(largura, altura, profundidade));

        }

        static double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        static double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        static double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}