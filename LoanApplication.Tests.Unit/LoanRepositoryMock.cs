using System.Collections.Generic;
using LoanApplication.Core.Model;
using LoanApplication.Core.Repository;

namespace LoanApplication.Tests.Unit
{
    public class LoanRepositoryMock : ILoanRepository
    {
        public List<Loan> GetCarLoans()
        {
            List<Loan> loans = new List<Loan>
            {
                new Loan{Amount = 120000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false },
                new Loan {Amount = 150000, Rate = 12.5, ServiceYear = 4, HasDefaulted = true },
                new Loan { Amount = 200000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false }
            };
            return loans;
        }

        public Loan GetLoanById(int id)
        {
            return new Loan { Amount = 20 };
        }

        public List<Core.Model.LoanType> GetLoanTypes()
        {
            List<Core.Model.LoanType> loanTypes = new List<Core.Model.LoanType>();
            //using (LoanContext context = new LoanContext())
            //{
            //    loanTypes=context.LoanType.ToList();
            //}
            return loanTypes;
        }
        

        public List<Person> GetCarLoanDefaulters(int year)
        {
            List<Person> defaulters = new List<Person>();
            //using (LoanContext context = new LoanContext())
            //{
            //    defaulters = context.Loan.Where(c => c.HasDefaulted 
            //               && c.ServiceYear == year).Select(c => c.Person).ToList();
            //}
            return defaulters;
        }

        public Core.Model.LoanType LoanType
        {
            get;
            set;
        }

        public float Rate
        {
            get;
            set;
        }
    }
}