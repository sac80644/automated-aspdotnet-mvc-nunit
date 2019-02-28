using System.Web.Mvc;
using BankingSite.Controllers;
using BankingSite.Models;
using Moq;
using NUnit.Framework;

namespace BankingSite.ControllerTests
{
    [TestFixture]
    public class LoanApplicationControllerTests
    {
        [Test]
        public void ShouldRenderDefaultView()
        {
            var fakerepository = new Mock<IRepository>();
            var fakeLoanApplicationScorer = new Mock<ILoanApplicationScorer>();

            var sut = new LoanApplicationController(fakerepository.Object, fakeLoanApplicationScorer.Object);

            var result = sut.Apply() as ViewResult;

            Assert.That(result.ViewName, Is.EqualTo("Apply"));
            
        }
    }
}
