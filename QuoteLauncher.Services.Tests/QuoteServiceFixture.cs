using NUnit.Framework;
using System.Collections.Generic;

namespace QuoteLauncher.Services.Tests
{
    [TestFixture]
    public class QuoteServiceFixture
    {
        private IQuoteService quoteService;

        [OneTimeSetUp]
        public void Init()
        {
            quoteService = new QuoteService();
        }

        [Test]
        public void GetAll()
        {
            // Arrange.
            var affinityCodes = new List<string> { "ASD", "KWF" };

            // Act.
            var x = quoteService.GetQuoteHyperlinks(affinityCodes);

            // Assert.
            Assert.AreEqual(x.Count, 2);
        }
    }
}