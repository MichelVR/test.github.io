using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_RadixWeb.Models
{
    public class MultipleHorario
    {

        public IEnumerable<Proyecto_RadixWeb.Models.cargos> objCargos { get; set; }
        public IEnumerable<Proyecto_RadixWeb.Models.diassemanales> objDias { get; set; }
        public IEnumerable<Proyecto_RadixWeb.Models.horario_laboral> objHorario { get; set; }
    }
}