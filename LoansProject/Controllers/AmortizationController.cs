using Microsoft.AspNetCore.Mvc;
using LoansProject.Models;
using LoansProject.ViewModels;
using LoansProject.Services;
using LoansProject.Business;

namespace LoansProject.Controllers
{
    public class AmortizationController : Controller
    {

        private readonly AmortizationService _amortizationService;
        public AmortizationController(AmortizationService amortizationService) 
        {
            _amortizationService = amortizationService;
        }

        public IActionResult Index()
        {
            _amortizationService.CalculateMonthlyPayment();
            return View();
        }

        [HttpPost]
        public IActionResult Test()
        {
            return RedirectToAction("Index");
        }
    }
}
