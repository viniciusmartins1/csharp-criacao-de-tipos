using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarParametrosNomeados()
        {
            ImprimirDetalhesDoPedido("Maria de Fatima", 31, "Caneca vermelha");

            //Argumentos nomeados
            ImprimirDetalhesDoPedido(numeroPedido: 31, nomeProduto: "Caneca Vermelha", vendedor: "Maria de Fátima");

            //Argumentos nomeados misturados
            ///
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, nomeProduto: "Caneca Vermelha");

            ///

            ImprimirDetalhesDoPedido(vendedor: "Maria de Fátima", 31, nomeProduto: "Caneca Vermelha");
            ImprimirDetalhesDoPedido("Maria de Fátima", numeroPedido: 31, "Caneca Vermelha");

        }

        static void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            //if (string IsNullOrWhiteSpace(vendedor))
            //{
                //throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio");
            //}

            Console.WriteLine($"Vendedor: {vendedor}, Pedido Nº.: {numeroPedido}, Nome do Produto {nomeProduto}");
        }
    }
}