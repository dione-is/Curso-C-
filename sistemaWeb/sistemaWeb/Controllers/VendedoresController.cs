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

        public async Task<IActionResult> Index()
        {
            var list = await _vendedorService.ObterTodosAsync();
            return View(list);
        }

        public async Task<IActionResult> Criar()
        {
            var departamentos = await _departamentoService.ObterTodosAsync();
            var viewModel = new VendedorFormViewModel {Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                var departamentos = await _departamentoService.ObterTodosAsync();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamentos };
                return View(viewModel);
            }
            await _vendedorService.InserirAsync(vendedor);
            return RedirectToAction(nameof(Index));
        }

       
        public async Task<IActionResult> Deletar(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não Informado"});
            }

            var obj = await _vendedorService.ObterPeloIdAsync(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não encontrado" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar (int id)
        {
            await _vendedorService.RemoverAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não Informado" });
            }

            var obj = await _vendedorService.ObterPeloIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não encontrado" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Editar (int ? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não Informado" });
            }

            var obj = await _vendedorService.ObterPeloIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não encontrado" });
            }

            List<Departamento> departamentos = await _departamentoService.ObterTodosAsync();
            VendedorFormViewModel viewModel = new VendedorFormViewModel { Vendedor = obj, Departamentos = departamentos};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                var departamentos = await _departamentoService.ObterTodosAsync();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamentos };
                return View(viewModel);
            }

            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { mensagem = "Id não conrresponde" });
            }

            try
            {
                await _vendedorService.AtualizarAsync(vendedor);
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