using System;
using System.Collections.Generic;
using QuoteLauncher.Domain;
using QuoteLauncher.Repositories;

namespace QuoteLauncher.Services
{
    public sealed class QuoteService : IQuoteService
    {
        private IQuoteRepository quoteRepository;

        public QuoteService()
        {
            quoteRepository = new QuoteRepository();
        }

        public QuoteHyperlink GetQuoteHyperlink(Quote quote)
        {
            throw new NotImplementedException();
        }

        public IList<QuoteHyperlink> GetQuoteHyperlinks(List<string> affinityCodes)
        {
            return quoteRepository.GetQuoteHyperlinks(affinityCodes);
        }
    }
}