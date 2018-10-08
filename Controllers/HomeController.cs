using Proyecto_RadixWeb.Models;
using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {

       radixEntities db = new radixEntities();

        public ActionResult Index()
        {


            if (User.IsInRole("Radix"))
            {


                return RedirectToAction("Index", "empresas", new { id = "Radix" });
                //return View("index","empresas");

            }
            else if (User.IsInRole("Administrador"))
            {


                string empresa = HttpContext.Session["Empresa"].ToString();
                string emp_id = HttpContext.Session["emp_id"].ToString();
                ViewBag.empresa = empresa;
                ViewBag.emp_id = emp_id;
                //esto es temporal hasta que se logre hacer funcional el dashboard de administrador
                return View("DashBoardAdmin");
                //return RedirectToAction("Index", "subempresas", new { emp_nom = empresa, emp_id = emp_id });

            }


            return View();
        }
        [Authorize]
        public ActionResult administrar()
        {
            return View("administrar");
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
