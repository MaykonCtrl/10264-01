using System.Web.Mvc;

namespace _007_MVCLifeCycle.Controllers
{
    public class PaginasController : Controlador
    {
        //
        // GET: /Paginas/

        public ActionResult Index()
        {
            return View();
        }
    }
}
