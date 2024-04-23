using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.tiposdejuegos
{
    internal class Deportes : VideoJuego
    {
        public string Deporte { get; set; }
        public string LicenciasOficiales { get; set; }

        public string inipartido()
        {
            return "El partido ha arrancado, buena suerte";

        }

        public string Trancurso()
        {
            string resultado1 = "Suena el Silvato";

            Random random = new Random();
            int randomN = random.Next(2);

            if (randomN == 0)
            {
                resultado1 += "\nTu Equipo lleva la Pelota";
            }
            else
            {
                resultado1 += "\nLe quitaron la pelota a tu equipo";

            }
            return resultado1;
        }

        public string falta()
        {
            string resultado = "Has cometido una infracción";

            Random random = new Random();
            int randomNumber = random.Next(2);

            if (randomNumber == 0)
            {
                resultado += "\nTarjeta Roja";
            }
            else
            {
                resultado += "\nTarjeta Amarillo";
            }

            return resultado;
        }

        public string MostrarDetallesDeporte()
        {
            string detallepadre = MostrarInformacion();
            return detallepadre + " \nDeporte: " + Deporte + " \nLicencias Oficiales: " + LicenciasOficiales;
        }
    }
}