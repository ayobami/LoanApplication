using System;
using System.Collections.Generic;
using System.Text;
using LoanApplication.Core.Repository;
using LoanApplication.Core.Model;
using LoanApplication.Core.Service;
using Moq;
using Xunit;

namespace LoanApplication.Tests.Unit
{
    public class LoanServiceTest
    {
        private Mock<ILoanRepository> loanRepository;
        private LoanService loanService;
        public LoanServiceTest()
        {

            loanRepository = new Mock<ILoanRepository>();
            List<Person> people = new List<Person>
            {
                new Person { FirstName = "Donald", LastName = "Duke", Age =30},
                new Person { FirstName = "Ayobami", LastName = "Adewole", Age =20}
            };
            loanRepository.Setup(x => x.GetCarLoanDefaulters(It.IsInRange<int>(1, 12, Range.Inclusive)))
                .Returns(() => people);
            loanService = new LoanService(loanRepository.Object);


           


            //loanRepository= new Mock<ILoanRepository>();
            //List<Loan> loans = new List<Loan>
            //{
            //    new Loan { Amount = 120000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false },
            //    new Loan { Amount = 150000, Rate = 12.5, ServiceYear = 4, HasDefaulted = true },
            //    new Loan { Amount = 200000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false }
            //};
            //loanRepository.Setup(x => x.GetCarLoans()).Returns(loans);

            //Random random = new Random();

            //loanRepository.As<>(()Setup(x => x.GetCarLoans(It.IsInRange<int>(1,12,Range.Inclusive))).Returns(loans);

            //loanRepository.Setup(x => x.GetCarLoans()).Returns(loans).Callback(() => CalculateRates());

            //List<Person> people = new List<Person>
            //{
            //    new Person { FirstName = "Donald", LastName = "Duke", Age =30},
            //    new Person { FirstName = "Ayobami", LastName = "Adewole", Age =20}
            //};

            //loanRepository.Setup(x => x.GetCarLoanDefaulters(It.Ref<>())).Returns(loans);

            //loanRepository.SetupProperty(x => x.Rate, 12.5);

            //loanRepository.SetupSet(x => x.Rate = 12.5F);

            //loanRepository.Verify(x => x.Rate, Times.);

            //loanService = new LoanService(loanRepository.Object);

            //Assert.All(people, x => Assert.Contains("Donald", x.FirstName));
        }

        [Fact]
        public void Test_GetBadCarLoans_ShouldReturnLoans()
        {

            List<Loan> badLoans = loanService.GetBadCarLoans();
            Assert.NotNull(badLoans);
        }

        [Fact]
        public void Test_GetOlderCarLoanDefaulters_ShouldReturnList()
        {
            List<Person> defaulters = loanService.GetOlderCarLoanDefaulters(12);
            Assert.NotNull(defaulters);
            Assert.All(defaulters, x => Assert.Contains("Donald", x.FirstName));
            loanRepository.Verify(x=>x.GetCarLoanDefaulters(It.IsInRange<int>(1, 12, Range.Inclusive)), Times.Exactly(2));
        }


    }
}
