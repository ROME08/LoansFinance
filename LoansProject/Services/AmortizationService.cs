using LoansProject.Interfaces;
using LoansProject.Models;

namespace LoansProject.Services
{
    public class AmortizationService
    {
        private readonly IAmortization _amortization;

        public AmortizationService(IAmortization amortization)
        {
            _amortization = amortization;
        }

        public decimal CalculateMonthlyPayment()
        {
            Loan myLoan = new Loan();
            return _amortization.calculatePayment(myLoan);
        }

        public IEnumerable<AmortizationSchedule> GetAmortizationSchedule()
        {
            return _amortization.generateSchedule();    
        }
    }
}
