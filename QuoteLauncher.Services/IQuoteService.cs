using QuoteLauncher.Domain;
using System.Collections.Generic;

namespace QuoteLauncher.Services
{
    public interface IQuoteService
    {
        QuoteHyperlink GetQuoteHyperlink(Quote quote);
        IList<QuoteHyperlink> GetQuoteHyperlinks(List<string> affinityCodes);
    }
}