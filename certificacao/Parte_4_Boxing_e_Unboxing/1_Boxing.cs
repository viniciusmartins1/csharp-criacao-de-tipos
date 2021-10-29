using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarBoxing()
        {
            int numero = 57;
            //nesta linha, numero esta sofrendo boxing
            object caixa = numero;


            Console.WriteLine(string.Concat("Resposta", numero, true));
        }
    }
}