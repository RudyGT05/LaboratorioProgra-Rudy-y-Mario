using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.tiposdejuegos
{



    internal class Shooter : VideoJuego
    {
        public bool realista { get; set; }
        public string ModoDeJuego { get; set; }

        public string ElegirMapa()
        {
            Random random = new Random();
            int mapaelegido = random.Next(1, 9);
            return "El mapa elejido es el numero:" + mapaelegido;

        }

        public string comprararma()
        {
            Random alear = new Random();
            int dinero = alear.Next(700, 1200);
            if (dinero >= 1000)
            {
                return "Dinero suficiente para comprar un arma, ya que el arma vale 1000 y tienes: " + dinero;

            }
            else { return "Dinero insuficiente para comprar un arma, ya que el arma vale 1000 y tienes: " + dinero; }
        }

        public string MostrarDetallesShooter()
        {
            string detallepadre = MostrarInformacion();
            return detallepadre + " \nRealista: " + realista + " \nModo de Juego: " + ModoDeJuego;
        }


    }
}