using AppTerceiro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppTerceiro.Controllers
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
            Fisica fisica = new Fisica
            {
                Id = 10,
                Nome = "Daniel",
                Sexo = 'M',
                CPF = 2387281702,
                RG = 0129092,
                Dig_RG = '4'

            };
            ViewData["Id"] = fisica.Id;
            ViewData["Nome"] = fisica.Nome;
            ViewData["Sexo"] = fisica.Sexo;
            ViewData["CPF"] = fisica.CPF;
            ViewData["RG"] = fisica.RG;
            ViewData["Dig_RG"] = fisica.Dig_RG;
            return View(fisica);
        }

        public IActionResult Privacy()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 4;
            pessoa.Nome = "Caetano";
            pessoa.Sexo = 'M';

            ViewBag.Id = pessoa.Id;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Sexo = pessoa.Sexo;
            return View(pessoa);
        }

        public IActionResult Juridica()
        {
            Juridica juridica = new Juridica();
            juridica.Id = 10;
            juridica.Nome = "Infinity System";
            juridica.CNPJ = 32901390190;
            juridica.IE = 128932383;
            return View(juridica);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
