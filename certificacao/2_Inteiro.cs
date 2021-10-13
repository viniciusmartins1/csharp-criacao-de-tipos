using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace certificacao
{
    partial class Program
    {
        static void ExecutarInteiros()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = '5'; //System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal
            //nivelDeAzul = -3;  //byte não aceita valores negativos
            short passageirosVoo = 230; //System.Int16
            passageirosVoo = -7;
            int populacao = 1500; //System.Int32
            populacao = -2300;
            long populacaoDoBrasil = 207_600_929; // +/- 207 milhões - System.Int64

            sbyte nivelDeBrilho = -127; //System.Sbyte 
            ushort passageirosNavio = 230; //System.UInt16 //não aceita numeros negativos
            uint estoque = 1500; //System.UInt32
            ulong populacaoDoMundo = 7_000_000_000; // 7 bilhoes - System.UInt64

            Console.WriteLine("resposta: {0}", resposta);

            Console.WriteLine("nivelDeAzul: {0}", nivelDeAzul);
            Console.WriteLine("passageirosVoo: {0}", passageirosVoo);
            Console.WriteLine("populacao: {0}", populacao);
            Console.WriteLine("populacaoDoBrasil: {0}", populacaoDoBrasil);

            Console.WriteLine("nivelDeBrilho: {0}", nivelDeBrilho);
            Console.WriteLine("passageirosNavio: {0}", passageirosNavio);
            Console.WriteLine("estoque: {0}", estoque);
            Console.WriteLine("populacaoDoMundo: {0}", populacaoDoMundo);


        }
    }
}