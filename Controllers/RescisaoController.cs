using calculo_de_rescisão.Models;
using calculo_de_rescisão.Services;
using Microsoft.AspNetCore.Mvc;

namespace calculo_de_rescisão.Controllers
{
    public class RescisaoController : Controller
    {
        private readonly CalculoRescisao _calculo;
        public RescisaoController(CalculoRescisao calculo)
        {
            _calculo = calculo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalcularRescisao(Rescisao rescisao) 
        {

           
            int diasTrabalhados = _calculo.DiasTrabalhados(rescisao);
            int mesesTrabalhados = _calculo.MesesTrabalhados(rescisao);
            int anosTrabalhados = _calculo.AnosTrabalhados(rescisao);
            double saldoSalario = _calculo.SaldoDoSalario(rescisao);
            double avisoPrevio = _calculo.AvisoPrevio(rescisao);
            double feriasProporcionais = _calculo.FeriasProporcionais(rescisao);
            double decimoTerceiro = _calculo.DecimoTerceiro(rescisao);
            double fgts = _calculo.FGTS(rescisao);

            
            ViewBag.DiasTrabalhados = diasTrabalhados;
            ViewBag.MesesTrabalhados = mesesTrabalhados;
            ViewBag.AnosTrabalhados = anosTrabalhados;
            ViewBag.SaldoSalario = saldoSalario.ToString("c2");
            ViewBag.AvisoPrevio = avisoPrevio.ToString("c2");
            ViewBag.FeriasProporcionais = feriasProporcionais.ToString("c2");
            ViewBag.DecimoTerceiro = decimoTerceiro.ToString("c2");
            ViewBag.FGTS = fgts.ToString("c2");

            return View("Resultado",rescisao);
        }
    }
}
