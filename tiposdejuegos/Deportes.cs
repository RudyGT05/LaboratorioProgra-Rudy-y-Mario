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

        public string falta()
        {
            return "haz cometido una infraccion";
        }
        public string MostrarDetallesDeporte()
        {
            string detallepadre = MostrarInformacion();
            return detallepadre + " \nDeporte: " + Deporte + " \nLicencias Oficiales: " + LicenciasOficiales;
        }
    }
}
