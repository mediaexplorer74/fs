namespace FSClient.Shared.Services
{
    using System;

    public class CheckForUpdatesResult(
        CheckForUpdatesResultType ResultType,
        Version? Version = null,
        Uri? InstallUpdateLink = null)
    {
        public Version? Version;
        public CheckForUpdatesResultType ResultType;
        public Uri InstallUpdateLink;
    }
}
