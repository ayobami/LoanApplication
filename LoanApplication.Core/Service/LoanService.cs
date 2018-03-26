using System;
using System.Collections.Generic;
using System.Linq;
using LoanApplication.Core.Model;
using LoanApplication.Core.Repository;

namespace LoanApplication.Core.Service
{
    internal class LoanService
    {
        private ILoanRepository loanRepository;
        public LoanService(ILoanRepository loanRepository)
        {
            this.loanRepository = loanRepository;
        }

        public List<Loan> GetBadCarLoans()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetCarLoanDefaulters(int year)
        {
            var defaulters= loanRepository.GetCarLoans()
                .Where(c => c.HasDefaulted && c.ServiceYear==year).Select(c=>c.Person).ToList();
            return defaulters;
        }

        public List<Person> GetOlderCarLoanDefaulters(int year)
        {
            List<Person> defaulters = loanRepository.GetCarLoanDefaulters(year);
            var filteredDefaulters = defaulters.Where(x => x.Age > 20).ToList();
            return filteredDefaulters;
        }
    }
}