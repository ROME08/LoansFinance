using LoansProject.Models;

namespace LoansProject.ViewModels
{
    public class AmortizationViewModel
    {
        public AmortizationSchedule? AmortizationSchedule {get;set;} 
        public Loan? Loan { get; set; } 
        public bool isFormatted { get; set; }

        public AmortizationViewModel() { }

    }
}
