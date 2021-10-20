using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
       static void ExecutarObject() 
       {
           int pontuacao = 10;
           Console.WriteLine($"Pontuacao: {pontuacao}");

           Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
           object meuObjeto;
           meuObjeto = pontuacao;
           Console.WriteLine($"meuObjeto: {meuObjeto}");
           Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");

           Console.WriteLine();
           Console.WriteLine("OBJECT COM REFERêNCIA DE OBJETO");

           meuObjeto = new Jogador();
           Jogador classRef;

           classRef = (Jogador)meuObjeto; //Conversão Explicita, ou "cast";

           Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");

        

       }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}