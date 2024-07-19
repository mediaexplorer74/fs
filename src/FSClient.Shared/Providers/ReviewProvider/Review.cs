﻿namespace FSClient.Shared.Providers
{
    using System;

    using FSClient.Shared.Models;

    public class Review(Site Site, string Id,
        string? Description,
        string? Reviewer,
        bool? IsUserReview = null,
        Uri? Avatar = null,
        DateTime? Date = null)
    {
        public string Id;
        public Site Site;
        public Uri Avatar;
        public DateTime? Date;
        public bool? IsUserReview;
        public string Reviewer;
        public string Description;
    }
}
