using BankingSite.Models;
using NUnit.Framework;

namespace BankingSite.UnitTests
{
    [TestFixture]
    public class LoanApplicationScorerTests
    {
        [Test]
        public void ShouldDeclineWhenNotTooYoungAndWealthyButPoorCredit_Classical()
        {
            var sut = new LoanApplicationScorer(new CreditHistoryChecker());

            var application = new LoanApplication
            {
                // Need to specify criteria that will cause 
                // real CreditHistoryChecker to decline
                FirstName = "Sarah",
                LastName = "Smith",

                AnnualIncome = 1000000.01m,
                Age = 22
            };

            sut.ScoreApplication(application);

            Assert.That(application.IsAccepted, Is.False);
        }
    }
}
