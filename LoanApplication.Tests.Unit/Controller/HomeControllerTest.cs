using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using LoanApplication.Controllers;
using LoanApplication.Core.Repository;
using Xunit;
using LoanApplication.Core.Model;

namespace LoanApplication.Tests.Unit.Controller
{
    public class HomeControllerTest
    {
        private Mock<ILoanRepository> loanRepository;
        private HomeController homeController;
        public HomeControllerTest()
        {
            loanRepository = new Mock<ILoanRepository>();
           // loanRepository.Setup(x => x.GetLoanTypes()).Returns(GetLoanTypes());
            homeController = new HomeController(loanRepository.Object);
        }

        //private List<LoanType> GetLoanTypes()
        //{
        //    var loanTypes = new List<LoanType>();
        //    loanTypes.Add(new LoanType()
        //    {
        //        Id = 1,
        //        Name = "Car Loan"
        //    });
        //    loanTypes.Add(new LoanType()
        //    {
        //        Id = 2,
        //        Name = "House Loan"
        //    });
        //    loanTypes.Add(new LoanType()
        //    {
        //        Id = 3,
        //        Name = "Education Loan"
        //    });
        //    return loanTypes;
        //}


        [Fact]
        public void TestMethod1()
        {
            Assert.Equal(8, (4 * 2));
        }


        [Theory,
        InlineData("name"),
        InlineData("word")]
        public void TestMethod2(string value)
        {
            Assert.Equal(4,value.Length);
        }


        [Fact]
        public void Assertions()
        {

            Assert.Equal(8 , (4*2));
            Assert.NotEqual(6, (4 * 2));

            List<string> list = new List<String> { "Rick", "John" };
            Assert.Contains("John", list);
            Assert.DoesNotContain("Dani", list);

            Assert.Empty(new List<String>());
            Assert.NotEmpty(list);

            Assert.False(false);
            Assert.True(true);

            Assert.NotNull(list);
            Assert.Null(null);            

        }

        public class IndexMethod :HomeControllerTest
        {
            [Fact]
            public void TestIndex()
            {               
                var result = homeController.Index();
                var viewResult = Assert.IsType<ViewResult>(result);
                var loanTypes = Assert.IsAssignableFrom<IEnumerable<LoanType>>(viewResult.ViewData["LoanTypes"]);
                Assert.Equal(3, loanTypes.Count());
            }            
        }

        public class AboutMethod : HomeControllerTest
        {
            [Fact]
            public void TestAbout()
            {
                var result = homeController.About();
                var viewResult = Assert.IsType<ViewResult>(result);
            }
        }
    }
}