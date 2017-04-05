using System;
using System.Collections.Generic;
using QuoteLauncher.Domain;
using System.Linq;

namespace QuoteLauncher.Repositories
{
    public sealed class QuoteRepository : IQuoteRepository
    {
        public QuoteHyperlink GetQuoteHyperlink(Quote quote)
        {
            throw new NotImplementedException();
        }

        public IList<QuoteHyperlink> GetQuoteHyperlinks(List<string> affinityCodes)
        {
            var qq = QuoteHyperlinksSection.Section.SettingsList.Select(q => new QuoteHyperlink
            {
                AffinityCode = q.AffinityCode,
                Name = q.Name,
                Url = q.Url
            })
            .Where(q => affinityCodes.Contains(q.AffinityCode))
            .ToList();

            return qq;
        }
    }
}