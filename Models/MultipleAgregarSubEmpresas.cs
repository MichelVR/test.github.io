using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_RadixWeb.Models
{
    public class MultipleAgregarSubEmpresas
    {

        public Proyecto_RadixWeb.Models.subempresas objSubEmpresas { get; set; }
        public Proyecto_RadixWeb.Models.regiones objRegiones { get; set; }
        public Proyecto_RadixWeb.Models.provincias objProvincias { get; set; }
        public Proyecto_RadixWeb.Models.comunas objComunas { get; set; }
    }
}