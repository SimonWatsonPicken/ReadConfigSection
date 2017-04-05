using System.Configuration;

namespace QuoteLauncher.Repositories
{
    public sealed class QuoteHyperlinkConfigElements : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new QuoteHyperlinkConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((QuoteHyperlinkConfigElement)element).AffinityCode;
        }
    }
}