using Fiap.Exercicio02.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio02.MVC.Controllers
{
    public class CarroController : Controller
    {

        //Simula Banco
        private static List<Carro> _lista = new List<Carro>();

        public ActionResult Listar()
        {
            //passa a lista para tela
            return View(_lista);
        }

        // GET: Carro
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Carro carro)
        {
            _lista.Add(carro);
            TempData["msg"] = "Cadastrado!";
            return View();
        }
    }
}