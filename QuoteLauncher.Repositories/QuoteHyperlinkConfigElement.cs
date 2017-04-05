using System.Configuration;

namespace QuoteLauncher.Repositories
{
    public sealed class QuoteHyperlinkConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("affinityCode", IsKey = true, IsRequired = true)]
        public string AffinityCode
        {
            get { return (string)base["affinityCode"]; }
            set { base["affinityCode"] = value; }
        }

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("url", IsRequired = true)]
        public string Url
        {
            get { return (string)base["url"]; }
            set { base["url"] = value; }
        }
    }
}