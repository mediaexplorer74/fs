﻿namespace FSClient.Providers
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    using FSClient.Shared.Helpers;
    using FSClient.Shared.Helpers.Web;
    using FSClient.Shared.Services;

    public class KinovodSiteProvider : BasePlayerJsSiteProvider
    {
        private static readonly Uri defaultMirror = new Uri("https://kinovod259.cc");

        public KinovodSiteProvider(IProviderConfigService providerConfigService) : base(
            providerConfigService,
            new ProviderConfig(Sites.Kinovod,
                mirrors: new[] { defaultMirror }))
        {
        }

        protected override MirrorGetterConfig PrepareMirrorGetterConfig()
        {
            return base.PrepareMirrorGetterConfig();
            //{
            //    MirrorFinder = MirrorFinder
            //};
        }

        private ValueTask<Uri?> MirrorFinder(Uri? previousMirror, CancellationToken cancellationToken)
        {
            var lastMirrorNumber = 192;
            string template;
            if ((previousMirror ?? defaultMirror) is { } mirrorToBase
                && mirrorToBase.Host.SplitLazy(2, StringSplitOptions.RemoveEmptyEntries, '.').LastOrDefault() is { } numberStr
                && int.TryParse(numberStr, out var number))
            {
                lastMirrorNumber = number;
                template = mirrorToBase.AbsoluteUri.Replace(numberStr, "{number}");
            }
            else
            {
                return new ValueTask<Uri?>((Uri?)null);
            }

            return Enumerable.Range(lastMirrorNumber + 1, 5)
                .Select(n => new Uri(template.Replace("{number}", n.ToString())))
                .ToAsyncEnumerable()
                .WhenAll(async (mirror, ct) =>
                {
                    var (mirrorToUse, _, isAvailable) = await mirror.IsAvailableWithLocationAsync(HttpMethod.Get, null, IsValidMirrorResponse, ct);
                    return isAvailable ? mirrorToUse : null;
                })
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
