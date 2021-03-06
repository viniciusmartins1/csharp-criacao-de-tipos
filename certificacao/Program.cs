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
            Console.WriteLine("8 - Tipos de Referencia");
            Console.WriteLine("9 - Classes");
            Console.WriteLine("10 - Interfaces");
            Console.WriteLine("11 - Delegate");
            Console.WriteLine("12 - Object");
            Console.WriteLine("13 - Dynamic");
            Console.WriteLine("14 - String");
            Console.WriteLine("15 - Metodos");
            Console.WriteLine("16 - Parâmetros Nomeados");
            Console.WriteLine("17 - Parâmetros Opcionais");
            Console.WriteLine("18 - Métodos de Extensão");
            Console.WriteLine("19 - Propriedades Indexadas");
            Console.WriteLine("20 - Sobrecargas");
            Console.WriteLine("21 - Métodos Substituidos");
            Console.WriteLine("22 - Boxing");
            Console.WriteLine("23 - Unboxing");
            Console.WriteLine("24 - Conversão Implícita");
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
                case "8":
                    ExecutarTiposDeReferencia();
                    break;
                case "9":
                    ExecutarClasses();
                    break;
                case "10":
                    ExecutarInterfaces();
                    break;
                case "11":
                    ExecutarDelegate();
                    break;
                case "12":
                    ExecutarObject();
                    break;
                case "13":
                    ExecutarDynamic();
                    break;
                case "14":
                    ExecutarString();
                    break;
                case "15":
                    ExecutarMetodos();
                    break;
                case "16":
                    ExecutarParametrosNomeados();
                    break;
                case "17":
                    ExecutarParametrosOpicionais();
                    break;
                case "18":
                    ExecutarMetodosDeExtensao();
                    break;
                case "19":
                    ExecutarPropriedadesIndexadas();
                    break;
                case "20":
                    ExecutarMetodosSobrecarregados();
                    break;
                case "21":
                    ExecutarMetodosSubstituidos();
                    break;
                case "22":
                    ExecutarBoxing();
                    break;
                case "23":
                    ExecutarUnboxing();
                    break;
                case "24":
                    ExecutarConversaoImplicita();
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }
            
        }
    }
}
