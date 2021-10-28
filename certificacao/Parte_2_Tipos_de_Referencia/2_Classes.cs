using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace certificacao
{
    partial class Program
    {

        static void ExecutarClasses()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS()
            { Latitude = 13.78, Longitude = 29.51};

            //posicao1 = new PosicaoGPS() { Latitude = 13.78, Longitude = 29.51 };
            posicao1 = new ClassePosicaoGPS(13.78, 29.51);

            Console.WriteLine(posicao1);

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78, 29.51, DateTime.Now);

            Console.WriteLine(posicao2);


        }
    }

    class ClassePosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public ClassePosicaoGPS()
        {
        }

        public ClassePosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude {Longitude}";
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

    }

    class PosicaoGPSComLeitura : ClassePosicaoGPS
    {
        private readonly DateTime dataLeitura;

        public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
        {
            this.dataLeitura = dataLeitura;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude {Longitude}, Data da Leitura {dataLeitura}";
        }


    }
}