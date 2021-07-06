using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using servico.Models;

namespace servico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Cadastro(itemServico novoItem)
        {
            Dados.servicoAtual.adicionaServico(novoItem);
            return View();
        }
         public IActionResult Cadastro()
        {
            
            return View();
        }
          public IActionResult Listagem()
        {
            List<ItemServico> servico = Dados.servicoAtual.listaServicos();
            return View(servico);
        }
        public IActionResult Sobre()
        {
            ItemServico novoItem = new ItemServico();

            novoItem.item = "Danielle";

            return View(novoItem);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
