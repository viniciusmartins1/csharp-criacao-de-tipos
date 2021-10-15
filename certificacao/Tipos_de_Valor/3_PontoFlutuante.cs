using System;

namespace certificacao
{
    partial class Program
    {
        static void ExecutarPontoFlutuante()
        {
            float idade = 15;
            idade = 15.5f;

            //double massa = 6e24;
            Console.WriteLine("long.MinValue: {0}", long.MinValue);
            Console.WriteLine("long.MinValue: {0}", long.MaxValue);

            //float massaDaTerra = 5.9736e24f; //System.Single
            //Console.WriteLine("MassaDaTerra: {}", massaDaTerra);

            //float numeroPI = 3.14159f; //System.Single
            //Console.WriteLine("Numero PI: {0}", numeroPI);

            //float numeroMuitoMaior = 6e100;
            double numeroMuitoMaior = 6e100;

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine("x * y = {0}", resultado1);
            Console.WriteLine("O resultado é do tipo: {0}", resultado1.GetType());
            //
            float z = 4.5f;

            var resultado2 = (x * y) / z;
            Console.WriteLine("x * y / z = {0}", resultado2);
            Console.WriteLine("O resultado é do tipo: {0}", resultado2.GetType());

            //C#        .NET            Faixa de Valores                Precisão
            //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=
            //float     System.Single   +/- 1.5e-45 to +/- 3.4e38       7 DÍGITOS 
            //double    System.Double   +/- 5.0e-324 to +/- 1.7e308     15-16 dÍGITOS 


        }
        
    }
}