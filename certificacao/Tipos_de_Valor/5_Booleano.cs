using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        
        static void ExecutarBooleano()
        {
            //bool possuiSaldo = 1;

            bool possuiSaldo = true;
            Console.WriteLine("possuiSaldo: {0}", possuiSaldo);

            int dias = DateTime.Now.Day;
            Console.WriteLine("dias: {0}", dias);

            // Atribui a diasPar o valor de uma expressão booleana.
            bool diasPar = (dias % 2 == 0);

            if(diasPar)
            {
                Console.WriteLine("dias é um número par");
            }
            else 
            {
                Console.WriteLine("dias é um número impar");
            }

        }
    }
}