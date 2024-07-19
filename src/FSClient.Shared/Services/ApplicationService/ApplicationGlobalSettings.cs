namespace FSClient.Shared.Services
{
    using System.Collections.Generic;
    using System.Linq;

    public record ApplicationGlobalSettings
    {
        public IEnumerable<ProviderConfig> ProviderConfigs { get; set; } = Enumerable.Empty<ProviderConfig>();

        public IReadOnlyDictionary<DistributionType, LatestVersionInfo> 
            LatestVersionPerDistributionType { get; set; } = new Dictionary<DistributionType, LatestVersionInfo>();
    }
}
