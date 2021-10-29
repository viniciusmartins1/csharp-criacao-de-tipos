using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarConversaoImplicita()
        {
            int inteiro = 2123456789;
            long interiroLongo = inteiro;
            Console.WriteLine(interiroLongo);



            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());
            
        }
    }
}


//TABELA DE CONVERSÕES NUMÉRICAS IMPLÍCITAS
//=========================================

//De        Para
//================================================================
//sbtye     short, int, long float, double ou decimal
//byte      short, ushort, int, uint, long, float, double ou decimal
//short     int, long, float, double, ou decimal
//ushort    int, uint, long, ulong, float, double, ou decimal    
//int       long, float, double, ou decimal
//uint      long, ulong, float, double, ou decimal
//long      float, double, ou decimal
//char      ushort, int, uint, long, ulong, float, double ou decimal
//float     double
//ulong     float, doulble ou decimal
//double    (nenhum)
//decimal   (nenhum)