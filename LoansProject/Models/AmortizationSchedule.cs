namespace LoansProject.Models
{
    public class AmortizationSchedule
    {
        int Id { get; set; }
        int Period { get; set; }
        decimal Payment { get; set; }
        decimal Principal { get; set; }
        decimal Interest { get; set; }
        
       
    }
}
