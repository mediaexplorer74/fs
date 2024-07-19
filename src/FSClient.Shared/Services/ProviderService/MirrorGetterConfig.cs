namespace FSClient.Shared.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MirrorGetterConfig
    {
        private static readonly Func<HttpResponseMessage, CancellationToken, ValueTask<bool>> 
            defaultValidator = new Func<HttpResponseMessage, CancellationToken, ValueTask<bool>>(
            (response, _) => new ValueTask<bool>(response.IsSuccessStatusCode));

        public MirrorGetterConfig(IReadOnlyList<Uri> mirrors)
        {
            Mirrors = mirrors;
        }

        public IReadOnlyCollection<Uri> Mirrors { get; set; }

        public HttpMethod HttpMethod { get; set; } = HttpMethod.Get;

        public IReadOnlyDictionary<string, string>? AdditionalHeaders { get; set; }

        public ProviderMirrorCheckingStrategy MirrorCheckingStrategy { get; set; } 
            = ProviderMirrorCheckingStrategy.Parallel;

        public Uri? HealthCheckRelativeLink { get; set; }

        public Func<HttpResponseMessage, CancellationToken, ValueTask<bool>> 
            Validator { get; set; } = defaultValidator;

        public Func<Uri?, CancellationToken, ValueTask<Uri?>>? MirrorFinder { get; set; }

        public HttpClientHandler? Handler { get; set; }
    }
}
