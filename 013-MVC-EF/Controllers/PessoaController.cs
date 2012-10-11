using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _013_MVC_EF.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            var e = new BancoEntities();

            return View(e.Pessoas);
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(int id)
        {
            var e = new BancoEntities();
            var pessoa = e.Pessoas.FirstOrDefault(p => p.Codigo == id);

            if (pessoa == null)
                return RedirectToAction("Index");
            else
                return View(pessoa);
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pessoa/Create

        [HttpPost]
        public ActionResult Create(Pessoa p)
        {
            try
            {
                var e = new BancoEntities();
                e.Pessoas.AddObject(p);
                e.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pessoa/Edit/5

        public ActionResult Edit(int id)
        {
            var e = new BancoEntities();
            var pessoa = e.Pessoas.FirstOrDefault(p => p.Codigo == id);

            if (pessoa == null)
                return RedirectToAction("Index");
            else
                return View(pessoa);
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Pessoa p)
        {
            try
            {
                var e = new BancoEntities();
                var pessoa = e.CreateEntityKey("Pessoas", p);

                Object o;

                if (e.TryGetObjectByKey(pessoa, out o))
                {
                    e.ApplyCurrentValues("Pessoas", p);
                }

                e.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pessoa/Delete/5

        public ActionResult Delete(int id)
        {
            var e = new BancoEntities();
            var pessoa = e.Pessoas.FirstOrDefault(p => p.Codigo == id);

            if (pessoa == null)
                return RedirectToAction("Index");
            else
                return View(pessoa);
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Pessoa p)
        {
            try
            {

                var e = new BancoEntities();
                e.Pessoas.DeleteObject(e.Pessoas.FirstOrDefault(pessoa => pessoa.Codigo == id));

                e.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
