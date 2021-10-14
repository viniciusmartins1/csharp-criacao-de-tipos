using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha uma OPÇÃO: ");
            Console.WriteLine("=--=-=-=-=-=-=-=-=-=-=-=-=-=- ");
            Console.WriteLine();
            Console.WriteLine("1 - Tipos de Valor");
            Console.WriteLine("2 - Tipos Inteiros");
            Console.WriteLine("3 - Ponto Flutuantes");
            Console.WriteLine("4 - Decimal");
            Console.WriteLine("5 - Booleano");
            Console.WriteLine("6 - Structs");
            Console.WriteLine("7 - Enum");
            var resultado = Console.ReadLine();

            switch (resultado)
            {
                case "1":
                    ExecutarTiposDeValor();
                    break;
                case "2":
                    ExecutarInteiros();
                    break;
                case "3":
                    ExecutarPontoFlutuante();
                    break;
                case "4":
                    ExecutarDecimal();
                    break;
                case "5":
                    ExecutarBooleano();
                    break;
                case "6":
                    ExecutarStructs();
                    break;
                case "7":
                    ExecutarEnum();
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }
            
        }
    }
}
