using LoanApplication.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Repository
{
    public class LoanRepository :ILoanRepository
    {
        public LoanType LoanType
        {
            get;
            set;
        }

        public float Rate
        {
            get;
            set;
        }
        public LoanRepository()
        {

        }
        public List<LoanType> GetLoanTypes()
        {
            List<LoanType> loanTypes= new List<LoanType>();
            //using (LoanContext context = new LoanContext())
            //{
            //    loanTypes=context.LoanType.ToList();
            //}
            return loanTypes;
        }

        public List<Loan> GetCarLoans()
        {
            List<Loan> loans = new List<Loan>();
            //using (LoanContext context = new LoanContext())
            //{
            //    loans = context.Loan.ToList();
            //}
            return loans;
        }

        public Loan GetLoanById(int id)
        {
            return new Loan { Amount = 20 };
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
    }

    //public class DataClass
    //{
    //    public static IEnumerable<object[]> GetLoanDTOs(int records)
    //    {
    //        var loanDTOs = new List<object[]>
    //            {
    //                new object[]
    //                {
    //                    new LoanDTO
    //                    {
    //                        LoanType = LoanType.CarLoan,
    //                        JobType = JobType.Professional,
    //                        LocationType = LocationType.Location1
    //                    }
    //                },
    //                new object[]
    //                {
    //                    new LoanDTO
    //                    {
    //                        LoanType = LoanType.CarLoan,
    //                        JobType = JobType.Professional,
    //                        LocationType = LocationType.Location2
    //                    }
    //                },
    //            };
    //        return loanDTOs.TakeLast(records);
    //    }
    //}
}


