using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarPropriedadesIndexadas()
        {

            var sala = new Sala();
            sala["D01"] = new ClinteCinema("Maria de Souza");
            sala["D02"] = new ClinteCinema("José da Silva");

            sala.ImprimirReservas();
        }
    }

    class ClinteCinema
    {
        public ClinteCinema(string nome)
        {
            Nome = nome;
        }

        public string Nome {get; set;}

        public override string ToString()
        {
            return Nome;
        }
    }

    class Sala
    {
        private readonly IDictionary<string, ClinteCinema> reservas = new Dictionary<string, ClinteCinema>();

        public ClinteCinema this[string codigoAssento]
        {
            get
            {
                return reservas[codigoAssento];
            }

            set
            {
                reservas[codigoAssento] = value;
            }

        }

        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos Reservados");
            Console.WriteLine("===================");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} - {reserva.Value}");
            }
        }

    }
}