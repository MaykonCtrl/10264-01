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

        /// <summary>
        /// Get: /Paginas/Foo
        /// </summary>
        /// <returns></returns>
        public ActionResult Foo()
        {
            return View();
        }

        /// <summary>
        /// Get: /Paginas/Mensagem
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public ActionResult Mensagem(string msg)
        {
            return View();
        }



    }
}
