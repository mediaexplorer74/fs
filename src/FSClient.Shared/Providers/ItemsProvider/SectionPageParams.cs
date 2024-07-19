namespace FSClient.Shared.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FSClient.Shared.Models;

    public class SectionPageParams
    {
        public SectionPageType PageType;
        public Site Site;
        public Section Section;

        public SectionPageParams(
            Site site, SectionPageType pageType, Section section,
            bool allowMultiTag = false, bool allowYearsRange = false,
            Range? yearLimit = null,
            IEnumerable<TagsContainer>? tagsContainers = null,
            IEnumerable<SortType>? sortTypes = null)
            /*: this(site, pageType, section)*/
        {
            AllowMultiTag = allowMultiTag;
            AllowYearsRange = allowYearsRange;
            YearLimit = yearLimit;
            TagsContainers = tagsContainers?.ToArray() ?? Array.Empty<TagsContainer>();
            SortTypes = sortTypes?.ToArray() ?? Array.Empty<SortType>();
        }

        public bool AllowMultiTag { get; set; }
        public bool AllowYearsRange { get; set; }

        public Range? YearLimit { get; set; }

        public IReadOnlyCollection<TagsContainer> TagsContainers { get; set; } = Array.Empty<TagsContainer>();

        public IReadOnlyCollection<SortType> SortTypes { get; set; } = Array.Empty<SortType>();
    }

    public class SectionPageFilter(SectionPageParams PageParams) : BaseSectionPageFilter<SectionPageParams>(PageParams)
    {
        public new PageParams PageParams = new PageParams();
    }
}
