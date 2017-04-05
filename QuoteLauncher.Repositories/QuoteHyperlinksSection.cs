using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace QuoteLauncher.Repositories
{
    public sealed class QuoteHyperlinksSection : ConfigurationSection
    {
        private static QuoteHyperlinksSection section = ConfigurationManager.GetSection("QuoteHyperlinks") as QuoteHyperlinksSection;

        public static QuoteHyperlinksSection Section => section;

        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        private QuoteHyperlinkConfigElements QuoteHyperlinkSettings
        {
            get { return (QuoteHyperlinkConfigElements)this[""]; }
            set { this[""] = value; }
        }

        public IEnumerable<QuoteHyperlinkConfigElement> SettingsList
        {
            get { return QuoteHyperlinkSettings.Cast<QuoteHyperlinkConfigElement>(); }
        }
    }
}