using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarString()
        {
            string a = "bom dia";
            string b = "b";
            //Adiciona ao conteudo de "b"
            b = b + "om dia";
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"(object)a == (object)b: {(object)a == (object)b}");

            string bomDia = "bom dia";
            Console.WriteLine($"bomDia[4]: {bomDia[4]}");

            var caracter = bomDia[4];
            Console.WriteLine($"caracter.GetType(): {caracter.GetType()}");


        }
    }
}