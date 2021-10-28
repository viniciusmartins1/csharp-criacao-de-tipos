using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarMetodos()
        {
            Retangulo retangulo = new Retangulo(10, 12);
            Console.WriteLine(retangulo.GetArea());

            Retangulo outroRetangulo = new Retangulo(10, 10);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura));

            outroRetangulo = new Retangulo(5, 6);
            Console.WriteLine(Retangulo.Semelhante(retangulo, outroRetangulo));


        }
    }

    class Retangulo
    {
        public double Altura { get; set;}
        public double Largura { get; set;}

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura}, largura: {largura}");


            var area = GetArea();
            Console.WriteLine($"area: {area}");
        }

        //public, internal, protected (+internal), private (+internal)

        internal double GetArea()
        {
            return Altura * Largura;
        }

        internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*propocao deste (this)retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura))  /* propocao do Outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a propoção inversa*/
                (outroRetanguloAltura / outroRetanguloLargura));
        }

        internal static bool Semelhante(Retangulo retangulo, Retangulo outroRetangulo)
        {
            return
                ((retangulo.Largura / retangulo.Altura) == /*propocao deste (this)retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura))  /* propocao do Outro retângulo*/
                ||
                ((retangulo.Altura / retangulo.Largura) == /*compara a propoção inversa*/
                (outroRetangulo.Altura / outroRetangulo.Largura));
        }
    }
}