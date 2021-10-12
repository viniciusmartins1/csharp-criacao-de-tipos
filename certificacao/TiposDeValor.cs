using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao
{
    partial class Program 
    {

        static void ExecutarTiposDeValor() 
        {
            int idade = 30;

            Console.WriteLine(idade);

            int copiaIdade = idade;

            Console.WriteLine("idade: {0}", idade);
            Console.WriteLine("idade: {0}", copiaIdade);

            idade = 23;

            Console.WriteLine("idade: {0}", idade);
            Console.WriteLine("idade: {0}", copiaIdade);

            int? idade2 = null;

        }
    }
}