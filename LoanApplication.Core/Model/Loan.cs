namespace LoanApplication.Core.Model
{
    public class Loan
    {
        public long Amount { get; set; }

        public double Rate { get; set; }

        public  short ServiceYear { get; set; }
        public bool HasDefaulted { get; set; }

        public Person Person { get; set; }
    }
}