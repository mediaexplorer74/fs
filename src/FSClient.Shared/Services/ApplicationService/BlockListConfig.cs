namespace FSClient.Shared.Services
{
    using System.Collections.Generic;
    using System.Linq;

    public record BlockListSettings
    {
        public IEnumerable<string> FullBlockedIds { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> BlockedIds { get; set; } = Enumerable.Empty<string>();

        public FilterRegexes FilterRegexes { get; set; } = new FilterRegexes();
    }
}
