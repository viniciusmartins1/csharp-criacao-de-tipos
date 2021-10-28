using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {
        static void ExecutarMetodosSubstituidos()   
        {
            Animal gato = new Gato() { Nome = "Bichano"};
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato() { Nome = "Pantera"};
            gata.Beber();
            gata.Comer();
            gata.Andar();
        }
    }

    class Animal
    {
        public String Nome {get; set; }

        public new void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }

        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }

        public new void Andar()
        {
           Console.WriteLine("Animal.Andar"); 
        }
    }

    class Gato : Animal
    {
        public void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }

        public override void Comer()
        {
            Console.WriteLine("Gato.Comer");
        }

        public void Andar()
        {
           Console.WriteLine("Gato.Andar"); 
        }
    }
}