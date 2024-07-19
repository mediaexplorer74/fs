namespace FSClient.Shared.Services
{
    using System;
    using System.Collections.Generic;

    using FSClient.Shared.Models;
    using FSClient.Shared.Providers;

    public record ProviderConfig
    {
        public ProviderConfig(Site site,
            ProviderRequirements? requirements = null,
            ProviderMirrorCheckingStrategy? mirrorCheckingStrategy = null,
            int? priority = null,
            bool? isVisibleToUser = null,
            bool? enforceDisabled = null,
            bool? isEnabledByDefault = null,
            bool? canBeMain = null,
            Uri? healthCheckRelativeLink = null,
            IEnumerable<Uri>? mirrors = null,
            IReadOnlyDictionary<string, string?>? properties = null)
        {
            Site = site;
            Requirements = requirements;
            MirrorCheckingStrategy = mirrorCheckingStrategy;
            Priority = priority;
            IsVisibleToUser = isVisibleToUser;
            EnforceDisabled = enforceDisabled;
            IsEnabledByDefault = isEnabledByDefault;
            CanBeMain = canBeMain;
            HealthCheckRelativeLink = healthCheckRelativeLink;
            Mirrors = mirrors;
            Properties = properties;
        }

        public Site Site { get; set; }

        public bool? IsVisibleToUser { get; set; }

        public bool? EnforceDisabled { get; set; }

        public bool? IsEnabledByDefault { get; set; }

        public bool? CanBeMain { get; set; }

        public Uri? HealthCheckRelativeLink { get; set; }

        public IEnumerable<Uri>? Mirrors { get; set; }

        public ProviderRequirements? Requirements { get; set; }

        public ProviderMirrorCheckingStrategy? MirrorCheckingStrategy { get; set; }

        public int? Priority { get; set; }

        public IReadOnlyDictionary<string, string?>? Properties { get; set; }
    }
}
