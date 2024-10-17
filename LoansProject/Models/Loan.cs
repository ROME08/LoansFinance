using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LoansProject.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public decimal amount { get; set; }
        public decimal interest { get; set; }
        public int years { get; set; }
        public PaymentPeriods period { get; set; }

        public int countPeriods()
        {
           int typeofperiod = (int)this.period;
           switch (typeofperiod)
            {
                case 0:
                    return 54;
                    break;
                case 1:
                    return 27;
                    break;
                case 2:
                    return 12;
                    break;
                default:
                    return 12;
            }
        }

        public int totalPeriods()
        {
            int typeofperiod = (int)this.period;
            int years = this.years;
            switch (typeofperiod)
            {
                case 0:
                    return 54 * years;
                    break;
                case 1:
                    return 27 * years;
                    break;
                case 2:
                    return 12 * years;
                    break;
                default:
                    return 12 * years;
            }
        }
        
       public Loan() { }

       public Loan( decimal amount, decimal interst, int years, PaymentPeriods period)
        {
            this.amount = amount;
            this.interest = interst;
            this.years = years;
            this.period = period;
        }
    }
}
