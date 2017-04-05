using QuoteLauncher.Domain;
using System.Collections.Generic;

namespace QuoteLauncher.Repositories
{
    public interface IQuoteRepository
    {
        QuoteHyperlink GetQuoteHyperlink(Quote quote);
        IList<QuoteHyperlink> GetQuoteHyperlinks(List<string> affinityCodes);
    }
}