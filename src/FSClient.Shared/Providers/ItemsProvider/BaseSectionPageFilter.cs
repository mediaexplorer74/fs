namespace FSClient.Shared.Providers
{
    using System;
    using System.Collections.Generic;

    using FSClient.Shared.Models;

    public abstract class BaseSectionPageFilter<TSectionPageParams>(TSectionPageParams PageParams)
        where TSectionPageParams : SectionPageParams
    {
        public TSectionPageParams PageParams;

        public Range? Year { get; set; }

        public bool FilterByFavorites { get; set; }

        public bool FilterByInHistory { get; set; }

        public IReadOnlyCollection<TitledTag> SelectedTags { get; set; } = Array.Empty<TitledTag>();

        public SortType? CurrentSortType { get; set; }
    }
}
