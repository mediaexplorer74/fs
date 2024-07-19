namespace FSClient.Shared.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FSClient.Shared.Models;

    public class SearchPageParams(Site Site, Section Section) : SectionPageParams(Site, SectionPageType.Search, Section)
    {
        public SearchPageParams(
            Site site, Section section,
            DisplayItemMode displayItemMode = DisplayItemMode.Normal, int minimumRequestLength = 2,
            bool allowMultiTag = false, bool allowYearsRange = false,
            Range? yearLimit = null,
            IEnumerable<TagsContainer>? tagsContainers = null,
            IEnumerable<SortType>? sortTypes = null)
            : this(site, section)
        {
            AllowMultiTag = allowMultiTag;
            AllowYearsRange = allowYearsRange;
            YearLimit = yearLimit;
            TagsContainers = tagsContainers?.ToArray() ?? Array.Empty<TagsContainer>();
            SortTypes = sortTypes?.ToArray() ?? Array.Empty<SortType>();
            DisplayItemMode = displayItemMode;
            MinimumRequestLength = minimumRequestLength;
        }

        public DisplayItemMode DisplayItemMode { get; set; } = DisplayItemMode.Normal;

        public int MinimumRequestLength { get; set; } = 2;
    }

    public class SearchPageFilter(SearchPageParams PageParams, string SearchRequest)
        : BaseSectionPageFilter<SearchPageParams>(PageParams)
    {
        public PageParams PageParams;
        public string SearchRequest;
    }
}
