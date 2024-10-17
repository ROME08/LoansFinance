using LoansProject.Models;

namespace LoansProject.Interfaces
{
    public interface IAmortization
    {
        decimal calculatePayment(Loan loan);

        decimal calcuatePeriodInterestRate(int periods, decimal anualInterestRate);

        IEnumerable<AmortizationSchedule> generateSchedule();
    }
}
