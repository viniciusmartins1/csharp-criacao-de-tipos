using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        
        static void ExecutarParametrosOpicionais()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas Walker");
            clienteEspecial.FazerPedido(1, "Residencial", 1);


            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);
            //
            clienteEspecial.FazerPedido(2, "Comercial");
            //
            clienteEspecial.FazerPedido(3);
        }
        
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Anônimo")
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 10)
        {
            Console.WriteLine($"cliente {nome}: produtoId: {produtoId}, endereço: {endereco}, quantidade: {quantidade}.");
        }
    }
}