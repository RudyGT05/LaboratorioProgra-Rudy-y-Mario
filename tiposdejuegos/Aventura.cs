using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.tiposdejuegos
{
    internal class Aventura : VideoJuego
    {
        public string personajepricipal { get; set; }
        public string Duracion { get; set; }

        public string Seleccionardifucultad()
        {

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    {
                        return "Haz elegido la dificultad Facil.";
                      
                        break;
                    }
                case 2:
                    {
                        return " Haz elegido la dificultad Media";
                        
                        break;
                    }
                case 3:
                    {
                        return "Haz elegido la dificultad Dificil";
                       
                        break;
                    }
                default:
                    {
                        return "Opcion no valida";
                       
                        break;
                    }

            }


        }

        public string elegirarma()
        {
            int opc1 = int.Parse(Console.ReadLine());

            switch (opc1)
            {
                case 1:
                    {
                        return "Tienes el arco en mano.";
                        break;
                    }
                case 2:
                    {
                        return " Tienes el piolet en mano";
                        break;
                    }
                case 3:
                    {
                        return "Tienes el machete en mano";
                        break;
                    }
                default:
                    {
                        return "Opcion no valida";
                        break;
                    }

            }
        }

        public string MostrarDetallesAventura()
        {
            string detallepadre = MostrarInformacion();
            return detallepadre + " \nPersonaje Pricipal: " + personajepricipal + " \nDuracion: " + Duracion;
        }








    }
}
