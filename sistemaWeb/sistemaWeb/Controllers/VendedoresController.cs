using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistemaWeb.Models;
using sistemaWeb.Services;

namespace sistemaWeb.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService service;

        public VendedoresController(VendedorService vendedorService)
        {
            service = vendedorService;
        }

        public IActionResult Index()
        {
            var list = service.ObterTodos();
            return View(list);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            service.Inserir(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}