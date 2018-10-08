using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_RadixWeb.Models
{
    public class MultipleEmpresa
    {


        public IEnumerable<Proyecto_RadixWeb.Models.empresas> objempresa { get; set; }
        public IEnumerable<Proyecto_RadixWeb.Models.subempresas> objsubempresa { get; set; }
    }
}