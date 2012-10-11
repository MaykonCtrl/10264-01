using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _010_Pessoa.Models;

namespace _010_Pessoa.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            return View(PessoaDB.Get());
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Detalhes(int id)
        {
            return View(PessoaDB.Get(id));
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Adicionar()
        {
            return View();
        } 

       
        
        //
        // GET: /Pessoa/Edit/5
 
        public ActionResult Editar(int id)
        {
            return View(PessoaDB.Get(id));
        }

       

        //
        // GET: /Pessoa/Delete/5
 
        public ActionResult Excluir(int id)
        {
            return View(PessoaDB.Get(id));
        }

        
    }
}
