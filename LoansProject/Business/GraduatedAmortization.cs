using LoansProject.Interfaces;
using LoansProject.Models;

namespace LoansProject.Business
{
    public class GraduatedAmortization : IAmortization
    {
         public decimal calculatePayment(Loan loan)
        {
            decimal periodInterestRate = calcuatePeriodInterestRate(loan.countPeriods(), loan.interest);
            decimal payment = (loan.amount * periodInterestRate) /            
           (1.00m - Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + periodInterestRate), - Convert.ToDouble(loan.totalPeriods()))));

            return payment;
        }

        public decimal calcuatePeriodInterestRate(int periods, decimal interest)
        {
           
            return interest / periods;
        }

        public IEnumerable<AmortizationSchedule> generateSchedule()
        {
            return new List<AmortizationSchedule>();
        }
    }
}
