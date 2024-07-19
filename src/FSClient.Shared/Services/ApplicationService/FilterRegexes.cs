namespace FSClient.Shared.Services
{
    using System.Text.RegularExpressions;

    public class FilterRegexes(
        Regex? SearchInputAdultFilter = null,
        Regex? ItemsByTitleAdultFilter = null)
    {
        public Regex? ItemsByTitleAdultFilter;
        internal Regex SearchInputAdultFilter;
    }
}
