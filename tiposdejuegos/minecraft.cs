using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.tiposdejuegos
{
    internal class Valorant : VideoJuego
    {
        public int Mapajugables { get; set; }
        public int PersonajesJugables { get; set; }

        public void ElegirMapa()
        {
            Random random = new Random();
            int mapaelegido = random.Next(1, 9);
            Console.WriteLine("El mapa elejido es el numero:" + mapaelegido);

        }
        public void comprararma()
        {
            Random alear = new Random();
            int dinero = alear.Next(700, 1200);
            if (dinero >= 1000)
            {
                Console.WriteLine("Dinero suficiente para comprar un arma, ya que el arma vale 1000 y tienes" + dinero);

            }
            else { Console.WriteLine("Dinero insuficiente para comprar un arma, ya que el arma vale 1000 y tienes " + dinero); }
        }



    }
}