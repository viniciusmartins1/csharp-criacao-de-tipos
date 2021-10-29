using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarUnboxing()
        {
            int numero = 57; // tipo de valor
            object caixa = numero;      //boxing


            try
            {
                 
                int unboxed = (int)caixa;

                Console.WriteLine("Unboxing.Ok");
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine("{0} Erro: unboxing incorreto.", e);
                throw;
            }
        }
    }
}