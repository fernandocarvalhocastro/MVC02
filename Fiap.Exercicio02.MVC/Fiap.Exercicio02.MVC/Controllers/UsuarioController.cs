using Fiap.Exercicio02.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio02.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Resultado(Usuario usuario)
        {
            TempData["sucesso"] = "Cadastro com sucesso";
            return View(usuario);
        }

    }
}