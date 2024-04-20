using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.tiposdejuegos
{
    internal class minecraft : VideoJuego
    {
        public int Mundon { get; set; }
        public int jugadorn { get; set; }
         
        public void CrearMundo()
        {
            
            Console.WriteLine("Nuevo Mundno creado");

        }
        public void ()
        {
            Random alear = new Random();
            int dinero = alear.Next(700, 1200);
            if (dinero >= 1000)
            {
                Console.WriteLine("Dinero suficiente para comprar un arma, ya que el arma vale 1000 y tienes"+dinero);

            }
            else { Console.WriteLine("Dinero insuficiente para comprar un arma, ya que el arma vale 1000 y tienes " +  dinero); }
        }



    }
}
