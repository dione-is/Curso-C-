using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistemaWeb.Models;
using sistemaWeb.Models.ViewsModels;
using sistemaWeb.Services;
using sistemaWeb.Services.Exceptions;

namespace sistemaWeb.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedorService vendedorService, DepartamentoService departamentoService)
        {
            _vendedorService = vendedorService;
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.ObterTodos();
            return View(list);
        }

        public IActionResult Criar()
        {
            var departamentos = _departamentoService.ObterTodos();
            var viewModel = new VendedorFormViewModel {Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendedorService.Inserir(vendedor);
            return RedirectToAction(nameof(Index));
        }

       
        public IActionResult Deletar(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não Informado"});
            }

            var obj = _vendedorService.ObterPeloId(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não encontrado" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar (int id)
        {
            _vendedorService.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não Informado" });
            }

            var obj = _vendedorService.ObterPeloId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não encontrado" });
            }

            return View(obj);
        }

        public IActionResult Editar (int ? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não Informado" });
            }

            var obj = _vendedorService.ObterPeloId(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não encontrado" });
            }

            List<Departamento> departamentos = _departamentoService.ObterTodos();
            VendedorFormViewModel viewModel = new VendedorFormViewModel { Vendedor = obj, Departamentos = departamentos};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Vendedor vendedor)
        {
            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não conrresponde" });
            }

            try
            {
                _vendedorService.Atualizar(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch(NotFoundExceptions e)
            {
                return RedirectToAction(nameof(Error), new { mensagem = e.Message});
            }
            catch (DbConcurrencyExceptions e)
            {
                return RedirectToAction(nameof(Error), new { mensagem = e.Message});
            }
        }

        public IActionResult Error(string mensagem)
        {
            var viewModel = new ErrorViewModel
            {
                Mensagem = mensagem,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }

    }
}