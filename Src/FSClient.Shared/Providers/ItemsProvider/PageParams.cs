using FSClient.Shared.Models;

namespace FSClient.Shared.Providers
{
    public class PageParams
    {
        public Section Section;
        public Site Site;
        public SectionPageType PageType;
        public System.Range? YearLimit;
    }
}