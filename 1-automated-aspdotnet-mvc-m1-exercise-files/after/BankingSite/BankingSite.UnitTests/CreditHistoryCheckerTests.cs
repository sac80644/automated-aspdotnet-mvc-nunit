using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSite.Models;
using NUnit.Framework;

namespace BankingSite.UnitTests
{
    [TestFixture]
    public class CreditHistoryCheckerTests
    {
        [Test]
        public void ShouldRecognizePeopleWithBadCredit()
        {
            var sut = new CreditHistoryChecker();

            var isCreditWorthy = sut.CheckCreditHistory("Sarah", "Smith");

            Assert.That(isCreditWorthy, Is.False);
        }

        [Test]
        public void ShouldRecognizePeopleWithGoodCredit()
        {
            var sut = new CreditHistoryChecker();

            var isCreditWorthy = sut.CheckCreditHistory("Tom", "Smith");

            Assert.That(isCreditWorthy, Is.True);
        }
    }
}
